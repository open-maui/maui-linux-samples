// DragDropPage - Native drag-and-drop, clipboard, and primary selection demos

using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Platform.Linux.Services;
using LinuxDragEventArgs = Microsoft.Maui.Platform.Linux.Services.DragEventArgs;
using LinuxDropEventArgs = Microsoft.Maui.Platform.Linux.Services.DropEventArgs;
using MauiClipboard = Microsoft.Maui.ApplicationModel.DataTransfer.Clipboard;

namespace ShellDemo;

public partial class DragDropPage : ContentPage
{
    private const int MaxLogEntries = 10;
    private readonly List<string> _eventLog = new();
    private bool _subscribed;

    public DragDropPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (_subscribed)
            return;

        DragDropService.Default.DragEnter += OnDragEnter;
        DragDropService.Default.DragOver += OnDragOver;
        DragDropService.Default.DragLeave += OnDragLeave;
        DragDropService.Default.Drop += OnDrop;
        _subscribed = true;
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        if (!_subscribed)
            return;

        DragDropService.Default.DragEnter -= OnDragEnter;
        DragDropService.Default.DragOver -= OnDragOver;
        DragDropService.Default.DragLeave -= OnDragLeave;
        DragDropService.Default.Drop -= OnDrop;
        _subscribed = false;
        SetDropZoneActive(false);
    }

    // --- Drop target -------------------------------------------------------

    private void OnDragEnter(object? sender, LinuxDragEventArgs e)
    {
        SetDropZoneActive(true);
        DropZoneLabel.Text = "Release to drop!";
        DragPositionLabel.Text = $"Position: ({e.X}, {e.Y})";

        var mimes = e.Data.SupportedMimeTypes.Length > 0
            ? $" [{string.Join(", ", e.Data.SupportedMimeTypes)}]"
            : string.Empty;
        LogEvent($"DragEnter at ({e.X}, {e.Y}){mimes}");
    }

    private void OnDragOver(object? sender, LinuxDragEventArgs e)
    {
        DragPositionLabel.Text = $"Position: ({e.X}, {e.Y})";
        // DragOver fires on every pointer move — coalesce into one log line.
        LogEvent($"DragOver at ({e.X}, {e.Y})", coalesce: true);
    }

    private void OnDragLeave(object? sender, EventArgs e)
    {
        SetDropZoneActive(false);
        DropZoneLabel.Text = "Drop text or files here";
        DragPositionLabel.Text = "";
        LogEvent("DragLeave");
    }

    private void OnDrop(object? sender, LinuxDropEventArgs e)
    {
        SetDropZoneActive(false);
        DropZoneLabel.Text = "Drop received!";
        DragPositionLabel.Text = "";

        var text = e.Data.Text ?? e.DroppedData;
        DroppedTextLabel.Text = string.IsNullOrEmpty(text)
            ? "Dropped text: (none)"
            : $"Dropped text: {text}";

        DroppedFilesLabel.Text = e.Data.FilePaths is { Length: > 0 } files
            ? "Dropped files:\n" + string.Join("\n", files.Select(f => $"  • {f}"))
            : "Dropped files: (none)";

        var fileCount = e.Data.FilePaths?.Length ?? 0;
        LogEvent($"Drop — text: {(string.IsNullOrEmpty(text) ? "no" : $"{text.Length} chars")}, files: {fileCount}");
    }

    private void SetDropZoneActive(bool active)
    {
        if (active)
        {
            DropZone.Stroke = new SolidColorBrush(Color.FromArgb("#2196F3"));
            DropZone.SetAppThemeColor(Border.BackgroundColorProperty,
                Color.FromArgb("#E3F2FD"), Color.FromArgb("#1A3A5C"));
        }
        else
        {
            // Restore the theme-aware resting colors.
            DropZone.SetAppTheme<Brush>(Border.StrokeProperty,
                new SolidColorBrush(Color.FromArgb("#E0E0E0")),
                new SolidColorBrush(Color.FromArgb("#424242")));
            DropZone.SetAppThemeColor(Border.BackgroundColorProperty,
                Color.FromArgb("#FFFFFF"), Color.FromArgb("#1E1E1E"));
        }
    }

    // --- Drag source -------------------------------------------------------

    private void OnDragSourcePressed(object? sender, EventArgs e)
    {
        // Must run during the button-press gesture: on Wayland start_drag needs
        // the press serial while the button is still held, and on X11 the drag
        // grabs the pointer of the press in progress. That is why this is wired
        // to Pressed rather than Clicked.
        var text = DragTextEntry.Text;
        if (string.IsNullOrEmpty(text))
        {
            DragStartResultLabel.Text = "Type some text above first.";
            return;
        }

        var started = DragDropService.Default.TryStartDrag(text);
        DragStartResultLabel.Text = started
            ? "TryStartDrag: true — keep the button held and drop onto another app."
            : "TryStartDrag: false (backend not ready or a drag is already in flight).";
        LogEvent($"TryStartDrag(\"{Truncate(text, 20)}\") => {started}");
    }

    // --- Clipboard / primary selection --------------------------------------

    private async void OnCopyToClipboardClicked(object? sender, EventArgs e)
    {
        await MauiClipboard.Default.SetTextAsync(ClipboardEntry.Text);
        ClipboardResultLabel.Text = $"Copied to clipboard: {ClipboardEntry.Text}";
    }

    private async void OnPasteFromClipboardClicked(object? sender, EventArgs e)
    {
        var text = await MauiClipboard.Default.GetTextAsync();
        ClipboardResultLabel.Text = text is null
            ? "Clipboard is empty (or has no text)."
            : $"Pasted from clipboard: {text}";
    }

    private async void OnSetPrimarySelectionClicked(object? sender, EventArgs e)
    {
        await PrimarySelectionService.Default.SetTextAsync(ClipboardEntry.Text);
        ClipboardResultLabel.Text = $"Primary selection set: {ClipboardEntry.Text} (middle-click paste in another app to verify)";
    }

    private async void OnGetPrimarySelectionClicked(object? sender, EventArgs e)
    {
        var text = await PrimarySelectionService.Default.GetTextAsync();
        ClipboardResultLabel.Text = text is null
            ? "Primary selection is empty (select some text somewhere first)."
            : $"Primary selection: {text}";
    }

    // --- Event log -----------------------------------------------------------

    private void LogEvent(string message, bool coalesce = false)
    {
        var entry = $"[{DateTime.Now:HH:mm:ss}] {message}";

        // Replace the previous entry when it is the same kind of event (keeps
        // high-frequency DragOver from flooding the enter/leave/drop sequence).
        if (coalesce && _eventLog.Count > 0 && _eventLog[0].Contains("DragOver"))
            _eventLog[0] = entry;
        else
            _eventLog.Insert(0, entry);

        if (_eventLog.Count > MaxLogEntries)
            _eventLog.RemoveRange(MaxLogEntries, _eventLog.Count - MaxLogEntries);

        EventLogLabel.Text = string.Join("\n", _eventLog);
    }

    private static string Truncate(string value, int max) =>
        value.Length <= max ? value : value[..max] + "…";
}
