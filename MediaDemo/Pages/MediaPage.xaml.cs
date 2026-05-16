using CommunityToolkit.Maui.Views;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Dispatching;

namespace MediaDemo.Pages;

public partial class MediaPage : ContentPage
{
    private IDispatcherTimer? _statusTimer;
    private bool _isSeeking;
    private DateTime _lastSeekAt = DateTime.MinValue;

    public MediaPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Periodic position refresh — MediaElement's PositionChanged event
        // doesn't fire on every frame on every platform, so a timer-driven
        // pull keeps the slider responsive across backends.
        _statusTimer = Dispatcher.CreateTimer();
        _statusTimer.Interval = TimeSpan.FromMilliseconds(250);
        _statusTimer.Tick += (_, _) =>
        {
            if (_isSeeking) return;

            var pos = Player.Position;
            var dur = Player.Duration;
            DurationLabel.Text = FormatTime(dur);
            if (dur.TotalSeconds > 0)
                PositionSlider.Maximum = dur.TotalSeconds;

            // After a seek the reported Position takes time to catch up —
            // GStreamer needs to receive (and for HTTP sources, sometimes
            // re-request) the bytes around the seek target, then decode the
            // first keyframe at or after it. Hold the slider at the user's
            // requested target until the reported position actually arrives
            // near it. Two guards combined:
            //   - 2s upper bound (don't anchor forever; release so the slider
            //     can show actual playback even if it differs from target)
            //   - "near enough" check (within 1s of the slider value)
            // Whichever fires first releases the anchor.
            var secsSinceSeek = (DateTime.UtcNow - _lastSeekAt).TotalSeconds;
            var posReachedTarget = Math.Abs(pos.TotalSeconds - PositionSlider.Value) < 1.0;
            if (secsSinceSeek < 2.0 && !posReachedTarget)
            {
                PositionLabel.Text = FormatTime(TimeSpan.FromSeconds(PositionSlider.Value));
                return;
            }

            PositionLabel.Text = FormatTime(pos);
            if (dur.TotalSeconds > 0)
                PositionSlider.Value = Math.Min(pos.TotalSeconds, dur.TotalSeconds);
        };
        _statusTimer.Start();
    }

    protected override void OnDisappearing()
    {
        _statusTimer?.Stop();
        _statusTimer = null;
        Player.Stop();
        base.OnDisappearing();
    }

    private void OnPlayClicked(object? sender, EventArgs e) => Player.Play();
    private void OnPauseClicked(object? sender, EventArgs e) => Player.Pause();
    private void OnStopClicked(object? sender, EventArgs e) => Player.Stop();

    private void OnMuteClicked(object? sender, EventArgs e)
    {
        Player.ShouldMute = !Player.ShouldMute;
        MuteButton.Text = Player.ShouldMute ? "Unmute" : "Mute";
    }

    private void OnVolumeChanged(object? sender, ValueChangedEventArgs e)
    {
        Player.Volume = e.NewValue;
    }

    private void OnPositionDragStarted(object? sender, EventArgs e)
    {
        // While the user holds the thumb, our 250ms timer must NOT overwrite
        // Slider.Value with Player.Position — otherwise the knob visibly jumps
        // back to the playback position mid-drag and the gesture feels stuck.
        // The timer respects _isSeeking, so flipping it true here is enough.
        _isSeeking = true;
    }

    private async void OnPositionDragCompleted(object? sender, EventArgs e)
    {
        var targetSeconds = PositionSlider.Value;
        try
        {
            // _isSeeking is already true from DragStarted; keep it true through
            // the awaited SeekTo so no timer tick sneaks in between commit and
            // anchor.
            await Player.SeekTo(TimeSpan.FromSeconds(targetSeconds));
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[MediaPage] SeekTo threw: {ex.Message}");
        }
        finally
        {
            _isSeeking = false;
            _lastSeekAt = DateTime.UtcNow;   // anchor the slider for a moment
        }
    }

    private async void OnLoadClicked(object? sender, EventArgs e)
    {
        var text = UrlEntry.Text?.Trim();
        if (string.IsNullOrEmpty(text))
        {
            await DisplayAlert("Empty URL", "Paste a media URL (http/https/file/...) or a local path into the entry first.", "OK");
            return;
        }

        try
        {
            MediaSource src;
            // Bare file paths aren't valid URIs — route them through FromFile.
            // Otherwise let MediaSource.FromUri handle the parse (http/https/rtsp/file://).
            if (text.StartsWith('/') || text.StartsWith('~'))
            {
                var expanded = text.StartsWith('~')
                    ? Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), text[1..].TrimStart('/'))
                    : text;
                if (!File.Exists(expanded))
                {
                    await DisplayAlert("File not found", $"No file at:\n{expanded}", "OK");
                    return;
                }
                src = MediaSource.FromFile(expanded);
            }
            else
            {
                src = MediaSource.FromUri(text);
            }

            Player.Source = src;
            Player.Play();
        }
        catch (Exception ex)
        {
            await DisplayAlert("Load failed", ex.Message, "OK");
        }
    }

    private static string FormatTime(TimeSpan t)
    {
        if (t == TimeSpan.Zero) return "0:00";
        if (t.TotalHours >= 1)
            return $"{(int)t.TotalHours}:{t.Minutes:00}:{t.Seconds:00}";
        return $"{t.Minutes}:{t.Seconds:00}";
    }
}
