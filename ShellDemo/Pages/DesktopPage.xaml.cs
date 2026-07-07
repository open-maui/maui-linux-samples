// DesktopPage - System tray icon and CUPS printing demos

using Microsoft.Maui.Controls;
using Microsoft.Maui.Platform.Linux.Services;
using SkiaSharp;

namespace ShellDemo;

public partial class DesktopPage : ContentPage
{
    private TrayIcon? _trayIcon;
    private string? _trayIconPath;
    private int _activatedCount;
    private string? _dialogPrinterName;
    private IReadOnlyDictionary<string, string>? _dialogOptions;

    public DesktopPage()
    {
        InitializeComponent();

        TrayAvailabilityLabel.Text = TrayIconService.IsAvailable
            ? "Tray backend: available on this desktop."
            : "Tray backend: NOT available — Show/Hide will be no-ops.";

        PrintAvailabilityLabel.Text = PrintService.IsAvailable
            ? "CUPS (libcups.so.2): available."
            : "CUPS (libcups.so.2): NOT installed — printing is disabled.";
    }

    // --- Tray icon -----------------------------------------------------------

    private void OnTrayShowClicked(object? sender, EventArgs e)
    {
        if (!TrayIconService.IsAvailable)
        {
            TrayStatusLabel.Text = "No tray backend available on this desktop.";
            return;
        }

        try
        {
            _trayIcon ??= CreateTrayIcon();
            _trayIcon.Title = TrayTitleEntry.Text ?? string.Empty;
            _trayIcon.Tooltip = TrayTooltipEntry.Text ?? string.Empty;
            _trayIcon.Show();
            _trayIcon.Update();
            TrayStatusLabel.Text = "Tray icon shown — look for the blue OpenMaui dot in the system tray.";
        }
        catch (Exception ex)
        {
            TrayStatusLabel.Text = $"Failed to show tray icon: {ex.Message}";
        }
    }

    private void OnTrayHideClicked(object? sender, EventArgs e)
    {
        _trayIcon?.Hide();
        TrayStatusLabel.Text = "Tray icon hidden.";
    }

    private void OnTrayUpdateClicked(object? sender, EventArgs e)
    {
        if (_trayIcon is null)
        {
            TrayStatusLabel.Text = "Show the tray icon first.";
            return;
        }

        _trayIcon.Title = TrayTitleEntry.Text ?? string.Empty;
        _trayIcon.Tooltip = TrayTooltipEntry.Text ?? string.Empty;
        _trayIcon.Update();
        TrayStatusLabel.Text = $"Tray icon updated at {DateTime.Now:HH:mm:ss}.";
    }

    private TrayIcon CreateTrayIcon()
    {
        var icon = new TrayIcon("com.openmaui.shelldemo")
        {
            Title = TrayTitleEntry.Text ?? string.Empty,
            Tooltip = TrayTooltipEntry.Text ?? string.Empty,
            IconPath = GetOrCreateTrayIconPng(),
        };

        // Menu actions are dispatched to the main thread by the platform, so
        // updating UI elements directly here is safe.
        icon.MenuItems.Add(new TrayMenuItem
        {
            Text = "Say Hello",
            Action = () => TrayLastActionLabel.Text = $"Last menu action: Say Hello at {DateTime.Now:HH:mm:ss}",
        });
        icon.MenuItems.Add(new TrayMenuItem
        {
            Text = "Ping",
            Action = () => TrayLastActionLabel.Text = $"Last menu action: Ping at {DateTime.Now:HH:mm:ss}",
        });
        icon.MenuItems.Add(new TrayMenuItem { IsSeparator = true });
        icon.MenuItems.Add(new TrayMenuItem
        {
            Text = "Hide Icon",
            Action = () =>
            {
                icon.Hide();
                TrayStatusLabel.Text = "Tray icon hidden (from tray menu).";
            },
        });

        icon.Activated += (_, _) =>
        {
            _activatedCount++;
            TrayActivatedLabel.Text = $"Activated fired: {_activatedCount} times";
        };

        return icon;
    }

    /// <summary>
    /// Renders a small tray PNG at runtime with SkiaSharp so the sample stays
    /// self-contained (no packaged image needed; the backends want a file path
    /// or a freedesktop icon name).
    /// </summary>
    private string GetOrCreateTrayIconPng()
    {
        if (_trayIconPath is not null && File.Exists(_trayIconPath))
            return _trayIconPath;

        var path = Path.Combine(Path.GetTempPath(), "openmaui-shelldemo-tray.png");

        const int size = 48;
        using var surface = SKSurface.Create(new SKImageInfo(size, size, SKColorType.Rgba8888, SKAlphaType.Premul));
        var canvas = surface.Canvas;
        canvas.Clear(SKColors.Transparent);

        using var circle = new SKPaint { Color = new SKColor(0x21, 0x96, 0xF3), IsAntialias = true };
        canvas.DrawCircle(size / 2f, size / 2f, size / 2f - 2, circle);

        using var font = new SKFont(SKTypeface.Default, size * 0.6f) { Embolden = true };
        using var textPaint = new SKPaint { Color = SKColors.White, IsAntialias = true };
        canvas.DrawText("M", size / 2f, size / 2f - (font.Metrics.Ascent + font.Metrics.Descent) / 2f,
            SKTextAlign.Center, font, textPaint);

        using var image = surface.Snapshot();
        using var data = image.Encode(SKEncodedImageFormat.Png, 100);
        using (var stream = File.Create(path))
            data.SaveTo(stream);

        _trayIconPath = path;
        return path;
    }

    // --- Printing ------------------------------------------------------------

    private async void OnListPrintersClicked(object? sender, EventArgs e)
    {
        if (!PrintService.IsAvailable)
        {
            PrinterListLabel.Text = "Printers: CUPS not available.";
            return;
        }

        PrinterListLabel.Text = "Printers: querying cupsd…";
        var printers = await PrintService.EnumeratePrintersAsync();
        PrinterListLabel.Text = printers.Count == 0
            ? "Printers: (none configured)"
            : "Printers:\n" + string.Join("\n", printers.Select(p =>
                $"  • {p.DisplayName}{(p.IsDefault ? "  (default)" : "")}"));
    }

    private async void OnPrintDialogClicked(object? sender, EventArgs e)
    {
        if (!PrintService.IsAvailable)
        {
            PrintDialogResultLabel.Text = "Dialog result: CUPS not available.";
            return;
        }

        var result = await PrintService.ShowPrintDialogAsync("ShellDemo Print");
        if (result is null)
        {
            PrintDialogResultLabel.Text = "Dialog result: cancelled (or GTK not available).";
            return;
        }

        _dialogPrinterName = result.PrinterName;
        _dialogOptions = result.Options;

        var options = result.Options.Count == 0
            ? "(none)"
            : string.Join(", ", result.Options.Select(kv => $"{kv.Key}={kv.Value}"));
        PrintDialogResultLabel.Text =
            $"Dialog result: printer '{result.PrinterName}'" +
            (result.PreviewRequested ? " (preview requested)" : "") +
            $"\nOptions: {options}";
    }

    private async void OnPrintTestPageClicked(object? sender, EventArgs e)
    {
        if (!PrintService.IsAvailable)
        {
            PrintJobResultLabel.Text = "Print job: CUPS not available.";
            return;
        }

        // Prefer the printer chosen in the dialog, else the system default.
        var printer = _dialogPrinterName;
        if (string.IsNullOrEmpty(printer))
        {
            var printers = await PrintService.EnumeratePrintersAsync();
            printer = (printers.FirstOrDefault(p => p.IsDefault) ?? printers.FirstOrDefault())?.Name;
        }

        if (string.IsNullOrEmpty(printer))
        {
            PrintJobResultLabel.Text = "Print job: no printer available (configure one in CUPS or use the dialog).";
            return;
        }

        PrintJobResultLabel.Text = $"Print job: submitting test page to '{printer}'…";

        // renderPage contract: return true to commit the page and be called
        // again; false stops — so render page 1 and stop on page 2.
        var result = await PrintService.PrintSkiaPagesAsync(
            printer,
            (canvas, page) =>
            {
                if (page > 1)
                    return false;
                RenderTestPage(canvas);
                return true;
            },
            new SKSize(612, 792),   // US Letter in points
            "OpenMaui ShellDemo Test Page",
            _dialogOptions);

        PrintJobResultLabel.Text = result.Status switch
        {
            PrintJobStatus.Submitted => $"Print job: Submitted (job id {result.JobId}) to '{printer}'.",
            PrintJobStatus.NothingToPrint => "Print job: NothingToPrint (no pages rendered).",
            _ => $"Print job: Failed — {result.ErrorMessage ?? "unknown error"}",
        };
    }

    private static void RenderTestPage(SKCanvas canvas)
    {
        canvas.Clear(SKColors.White);

        using var titleFont = new SKFont(SKTypeface.Default, 28) { Embolden = true };
        using var bodyFont = new SKFont(SKTypeface.Default, 14);
        using var black = new SKPaint { Color = SKColors.Black, IsAntialias = true };

        canvas.DrawText("OpenMaui ShellDemo Test Page", 60, 90, SKTextAlign.Left, titleFont, black);
        canvas.DrawText($"Printed: {DateTime.Now:yyyy-MM-dd HH:mm:ss}", 60, 130, SKTextAlign.Left, bodyFont, black);

        using var rectStroke = new SKPaint
        {
            Color = new SKColor(0x21, 0x96, 0xF3),
            IsAntialias = true,
            Style = SKPaintStyle.Stroke,
            StrokeWidth = 3,
        };
        canvas.DrawRect(SKRect.Create(60, 170, 492, 220), rectStroke);
        canvas.DrawText("If you can read this, PrintSkiaPagesAsync works.", 80, 290, SKTextAlign.Left, bodyFont, black);
    }
}
