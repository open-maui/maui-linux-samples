// ControlsPage - Demonstrates various MAUI controls

using Microsoft.Maui.Controls;

namespace ShellDemo;

public partial class ControlsPage : ContentPage
{
    public ControlsPage()
    {
        InitializeComponent();
    }

    private void OnButtonClicked(object? sender, EventArgs e)
    {
        if (sender is Button btn)
        {
            ButtonResultLabel.Text = $"{btn.Text} clicked!";
        }
    }

    private void OnSwitchToggled(object? sender, ToggledEventArgs e)
    {
        SwitchLabel.Text = e.Value ? "On" : "Off";
    }

    private void OnSliderValueChanged(object? sender, ValueChangedEventArgs e)
    {
        SliderLabel.Text = $"Value: {(int)e.NewValue}";
    }

    private void OnPickerSelectedIndexChanged(object? sender, EventArgs e)
    {
        if (MainPicker.SelectedIndex >= 0)
        {
            PickerLabel.Text = $"Selected: {MainPicker.ItemsSource[MainPicker.SelectedIndex]}";
        }
    }
}
