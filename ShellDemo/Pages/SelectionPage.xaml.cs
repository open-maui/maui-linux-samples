// SelectionPage - CheckBox, Switch, Slider Demo

using Microsoft.Maui.Controls;

namespace ShellDemo;

public partial class SelectionPage : ContentPage
{
    private int _eventCount = 0;

    public SelectionPage()
    {
        InitializeComponent();
    }

    private void OnCheckboxChanged(object? sender, CheckedChangedEventArgs e)
    {
        if (sender == Checkbox1)
            LogEvent($"Checkbox 1: {(e.Value ? "Checked" : "Unchecked")}");
        else if (sender == Checkbox2)
            LogEvent($"Checkbox 2: {(e.Value ? "Checked" : "Unchecked")}");
    }

    private void OnColoredCheckboxChanged(object? sender, CheckedChangedEventArgs e)
    {
        if (sender is CheckBox cb)
            LogEvent($"{cb.Color} checkbox: {(e.Value ? "Checked" : "Unchecked")}");
    }

    private void OnSwitchToggled(object? sender, ToggledEventArgs e)
    {
        SwitchStatusLabel.Text = e.Value ? "On" : "Off";
        LogEvent($"Switch toggled: {(e.Value ? "ON" : "OFF")}");
    }

    private void OnColoredSwitchToggled(object? sender, ToggledEventArgs e)
    {
        if (sender is Switch sw)
            LogEvent($"{sw.OnColor} switch: {(e.Value ? "ON" : "OFF")}");
    }

    private void OnSliderValueChanged(object? sender, ValueChangedEventArgs e)
    {
        SliderValueLabel.Text = $"Value: {(int)e.NewValue}";
        LogEvent($"Slider value: {(int)e.NewValue}");
    }

    private void OnTempSliderValueChanged(object? sender, ValueChangedEventArgs e)
    {
        TempLabel.Text = $"{(int)e.NewValue}°C";
        LogEvent($"Temperature: {(int)e.NewValue}°C");
    }

    private void OnColoredSliderValueChanged(object? sender, ValueChangedEventArgs e)
    {
        LogEvent($"Colored slider: {(int)e.NewValue}");
    }

    private void LogEvent(string message)
    {
        _eventCount++;
        var timestamp = DateTime.Now.ToString("HH:mm:ss");
        EventLogLabel.Text = $"[{timestamp}] {_eventCount}. {message}\n{EventLogLabel.Text}";
    }
}
