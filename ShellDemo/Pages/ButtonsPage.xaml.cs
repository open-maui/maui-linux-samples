// ButtonsPage - Comprehensive Button Control Demo

using Microsoft.Maui.Controls;

namespace ShellDemo;

public partial class ButtonsPage : ContentPage
{
    private int _eventCount = 0;

    public ButtonsPage()
    {
        InitializeComponent();
    }

    private void OnDefaultButtonClicked(object? sender, EventArgs e)
    {
        LogEvent("Default Button clicked");
    }

    private void OnStyledButtonClicked(object? sender, EventArgs e)
    {
        if (sender is Button btn)
        {
            LogEvent($"{btn.Text} button clicked");
        }
    }

    private void OnEnabledButtonClicked(object? sender, EventArgs e)
    {
        LogEvent("Enabled button clicked");
    }

    private void OnToggleButtonClicked(object? sender, EventArgs e)
    {
        DisabledButton.IsEnabled = !DisabledButton.IsEnabled;
        DisabledButton.Text = DisabledButton.IsEnabled ? "Now Enabled!" : "Disabled Button";
        LogEvent($"Toggled button to: {(DisabledButton.IsEnabled ? "Enabled" : "Disabled")}");
    }

    private void OnVariationButtonClicked(object? sender, EventArgs e)
    {
        if (sender is Button btn)
        {
            LogEvent($"{btn.Text} button clicked");
        }
    }

    private void LogEvent(string message)
    {
        _eventCount++;
        var timestamp = DateTime.Now.ToString("HH:mm:ss");
        EventLogLabel.Text = $"[{timestamp}] {_eventCount}. {message}\n{EventLogLabel.Text}";
    }
}
