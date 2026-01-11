// ProgressPage - ProgressBar and ActivityIndicator Demo

using Microsoft.Maui.Controls;

namespace ShellDemo;

public partial class ProgressPage : ContentPage
{
    private int _eventCount = 0;
    private bool _isAnimating = false;

    public ProgressPage()
    {
        InitializeComponent();
    }

    private void OnToggleIndicatorClicked(object? sender, EventArgs e)
    {
        ToggleIndicator.IsRunning = !ToggleIndicator.IsRunning;
        LogEvent($"ActivityIndicator: {(ToggleIndicator.IsRunning ? "Started" : "Stopped")}");
    }

    private void OnProgressSliderValueChanged(object? sender, ValueChangedEventArgs e)
    {
        AnimatedProgress.Progress = e.NewValue / 100.0;
        ProgressLabel.Text = $"Progress: {(int)e.NewValue}%";
    }

    private void OnResetClicked(object? sender, EventArgs e)
    {
        AnimatedProgress.Progress = 0;
        ProgressSlider.Value = 0;
        LogEvent("Progress reset to 0%");
    }

    private async void OnAnimateClicked(object? sender, EventArgs e)
    {
        if (_isAnimating) return;
        _isAnimating = true;
        LogEvent("Animation started");

        for (int i = (int)ProgressSlider.Value; i <= 100; i += 5)
        {
            AnimatedProgress.Progress = i / 100.0;
            ProgressSlider.Value = i;
            await Task.Delay(100);
        }

        _isAnimating = false;
        LogEvent("Animation completed");
    }

    private async void OnSimulateDownloadClicked(object? sender, EventArgs e)
    {
        if (_isAnimating) return;
        _isAnimating = true;
        LogEvent("Download simulation started");

        AnimatedProgress.Progress = 0;
        ProgressSlider.Value = 0;

        var random = new Random();
        double progress = 0;
        while (progress < 1.0)
        {
            progress += random.NextDouble() * 0.1;
            if (progress > 1.0) progress = 1.0;
            AnimatedProgress.Progress = progress;
            ProgressSlider.Value = progress * 100;
            await Task.Delay(200 + random.Next(300));
        }

        _isAnimating = false;
        LogEvent("Download simulation completed");
    }

    private void LogEvent(string message)
    {
        _eventCount++;
        var timestamp = DateTime.Now.ToString("HH:mm:ss");
        EventLogLabel.Text = $"[{timestamp}] {_eventCount}. {message}\n{EventLogLabel.Text}";
    }
}
