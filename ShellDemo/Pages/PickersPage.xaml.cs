// PickersPage - Picker, DatePicker, TimePicker Demo

using Microsoft.Maui.Controls;

namespace ShellDemo;

public partial class PickersPage : ContentPage
{
    private int _eventCount = 0;

    public PickersPage()
    {
        InitializeComponent();

        // Set up date picker with current date
        BasicDatePicker.Date = DateTime.Today;
        DateSelectedLabel.Text = $"Selected: {DateTime.Today:d}";

        // Set up range date picker
        var startOfMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
        var endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);
        RangeDatePicker.MinimumDate = startOfMonth;
        RangeDatePicker.MaximumDate = endOfMonth;
        RangeDatePicker.Date = DateTime.Today;

        // Set up styled date picker
        StyledDatePicker.Date = DateTime.Today.AddDays(7);

        // Set up time picker
        BasicTimePicker.Time = DateTime.Now.TimeOfDay;
        TimeSelectedLabel.Text = $"Selected: {DateTime.Now:t}";
    }

    private void OnFruitPickerChanged(object? sender, EventArgs e)
    {
        if (FruitPicker.SelectedIndex >= 0)
        {
            var item = FruitPicker.ItemsSource[FruitPicker.SelectedIndex]?.ToString();
            FruitSelectedLabel.Text = $"Selected: {item}";
            LogEvent($"Fruit selected: {item}");
        }
    }

    private void OnColorPickerChanged(object? sender, EventArgs e)
    {
        if (ColorPicker.SelectedIndex >= 0)
        {
            var item = ColorPicker.ItemsSource[ColorPicker.SelectedIndex]?.ToString();
            LogEvent($"Color selected: {item}");
        }
    }

    private void OnSizePickerChanged(object? sender, EventArgs e)
    {
        if (SizePicker.SelectedIndex >= 0)
        {
            var item = SizePicker.ItemsSource[SizePicker.SelectedIndex]?.ToString();
            LogEvent($"Size selected: {item}");
        }
    }

    private void OnDateSelected(object? sender, DateChangedEventArgs e)
    {
        DateSelectedLabel.Text = $"Selected: {e.NewDate:d}";
        LogEvent($"Date selected: {e.NewDate:d}");
    }

    private void OnRangeDateSelected(object? sender, DateChangedEventArgs e)
    {
        LogEvent($"Date (limited): {e.NewDate:d}");
    }

    private void OnStyledDateSelected(object? sender, DateChangedEventArgs e)
    {
        LogEvent($"Styled date: {e.NewDate:d}");
    }

    private void OnTimePickerPropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(TimePicker.Time))
        {
            var time = BasicTimePicker.Time;
            TimeSelectedLabel.Text = $"Selected: {time:hh\\:mm}";
            LogEvent($"Time selected: {time:hh\\:mm}");
        }
    }

    private void OnStyledTimePickerPropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(TimePicker.Time))
        {
            LogEvent($"Styled time: {StyledTimePicker.Time:hh\\:mm}");
        }
    }

    private void OnSetAlarmClicked(object? sender, EventArgs e)
    {
        LogEvent($"Alarm set for {AlarmTimePicker.Time:hh\\:mm}");
    }

    private void LogEvent(string message)
    {
        _eventCount++;
        var timestamp = DateTime.Now.ToString("HH:mm:ss");
        EventLogLabel.Text = $"[{timestamp}] {_eventCount}. {message}\n{EventLogLabel.Text}";
    }
}
