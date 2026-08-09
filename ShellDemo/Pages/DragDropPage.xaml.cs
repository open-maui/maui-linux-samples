// DragDropPage - Native drag-and-drop, clipboard, and primary selection demos

using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Platform.Linux.Services;
using SkiaSharp;
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

    private void OnDragFilePressed(object? sender, EventArgs e)
    {
        // Write a throwaway file and drag it as text/uri-list. Drop it onto a
        // file manager (Dolphin/Nautilus) or a text editor.
        var path = Path.Combine(Path.GetTempPath(), "openmaui-drag-sample.txt");
        try
        {
            File.WriteAllText(path, "Dragged out of OpenMaui ShellDemo.\n");
        }
        catch (Exception ex)
        {
            DragStartResultLabel.Text = $"Could not create sample file: {ex.Message}";
            return;
        }

        var started = DragDropService.Default.TryStartDrag(DragPayload.FromFiles(path));
        DragStartResultLabel.Text = started
            ? $"Dragging file {path} — hold and drop onto a file manager."
            : "TryStartDrag(file): false (backend not ready or a drag is in flight).";
        LogEvent($"TryStartDrag(file) => {started}");
    }

    private void OnDragImagePressed(object? sender, EventArgs e)
    {
        // Render a small PNG in memory and drag it as image/png. Drop it onto
        // an image viewer, a chat app, or GIMP.
        byte[] png;
        try
        {
            png = RenderSamplePng();
        }
        catch (Exception ex)
        {
            DragStartResultLabel.Text = $"Could not render image: {ex.Message}";
            return;
        }

        var started = DragDropService.Default.TryStartDrag(DragPayload.FromImage(png, "image/png"));
        DragStartResultLabel.Text = started
            ? $"Dragging a {png.Length}-byte PNG — hold and drop onto an image viewer."
            : "TryStartDrag(image): false (backend not ready or a drag is in flight).";
        LogEvent($"TryStartDrag(image, {png.Length}B) => {started}");
    }

    private static byte[] RenderSamplePng()
    {
        using var bitmap = new SKBitmap(240, 120);
        using (var canvas = new SKCanvas(bitmap))
        {
            canvas.Clear(new SKColor(0x21, 0x96, 0xF3));
            using var paint = new SKPaint { Color = SKColors.White, IsAntialias = true };
            using var font = new SKFont { Size = 28 };
            canvas.DrawText("OpenMaui", 24, 70, SKTextAlign.Left, font, paint);
        }
        using var image = SKImage.FromBitmap(bitmap);
        using var data = image.Encode(SKEncodedImageFormat.Png, 100);
        return data.ToArray();
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
