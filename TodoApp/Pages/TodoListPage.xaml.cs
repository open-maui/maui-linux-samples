// TodoListPage - Main page for viewing todos with XAML support

using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using System.Globalization;

namespace TodoApp;

public partial class TodoListPage : ContentPage
{
    private readonly TodoService _service = TodoService.Instance;
    private bool _isNavigating; // Guard against double navigation

    public TodoListPage()
    {
        Console.WriteLine("[TodoListPage] Constructor starting");
        InitializeComponent();

        TodoCollectionView.ItemsSource = _service.Todos;
        UpdateStats();

        // Subscribe to theme changes to verify event is firing
        if (Application.Current != null)
        {
            Application.Current.RequestedThemeChanged += (s, e) =>
            {
                Console.WriteLine($"[TodoListPage] RequestedThemeChanged event received! NewTheme={e.RequestedTheme}");
            };
        }

        Console.WriteLine("[TodoListPage] Constructor finished");
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Reset navigation guard when page reappears
        _isNavigating = false;

        // Refresh indexes for alternating row colors
        _service.RefreshIndexes();

        // Refresh the collection view
        TodoCollectionView.ItemsSource = null;
        TodoCollectionView.ItemsSource = _service.Todos;
        UpdateStats();
        UpdateThemeIcon();
    }

    private async void OnAddClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewTodoPage());
    }

    private async void OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        // Guard against double navigation
        if (_isNavigating)
        {
            return;
        }

        if (e.CurrentSelection.FirstOrDefault() is TodoItem todo)
        {
            _isNavigating = true;
            TodoCollectionView.SelectedItem = null; // Deselect immediately
            await Navigation.PushAsync(new TodoDetailPage(todo));
            // Note: _isNavigating is reset in OnAppearing when we return
        }
    }

    private void UpdateStats()
    {
        var completed = _service.CompletedCount;
        var total = _service.TotalCount;

        if (total == 0)
        {
            StatsLabel.Text = "No tasks";
        }
        else
        {
            StatsLabel.Text = $"Tasks: {completed} of {total} completed";
        }
    }

    private void UpdateThemeIcon()
    {
        // Check UserAppTheme first, fall back to RequestedTheme
        var userTheme = Application.Current?.UserAppTheme ?? AppTheme.Unspecified;
        var effectiveTheme = userTheme != AppTheme.Unspecified ? userTheme : Application.Current?.RequestedTheme ?? AppTheme.Light;
        var isDarkMode = effectiveTheme == AppTheme.Dark;

        // Show sun icon in dark mode (to switch to light), moon icon in light mode (to switch to dark)
        ThemeToggleButton.Source = isDarkMode ? "light_mode_white.svg" : "dark_mode_white.svg";
        Console.WriteLine($"[TodoListPage] UpdateThemeIcon: UserAppTheme={userTheme}, RequestedTheme={Application.Current?.RequestedTheme}, isDarkMode={isDarkMode}");
    }

    private void OnThemeToggleClicked(object? sender, EventArgs e)
    {
        if (Application.Current == null) return;

        // Check current effective theme
        var userTheme = Application.Current.UserAppTheme;
        var effectiveTheme = userTheme != AppTheme.Unspecified ? userTheme : Application.Current.RequestedTheme;
        var isDarkMode = effectiveTheme == AppTheme.Dark;

        // Toggle to the opposite theme
        var newTheme = isDarkMode ? AppTheme.Light : AppTheme.Dark;
        Application.Current.UserAppTheme = newTheme;

        Console.WriteLine($"[TodoListPage] Theme toggled from {effectiveTheme} to {newTheme}");
        UpdateThemeIcon();
    }
}

/// <summary>
/// Converter for alternating row background colors with Light/Dark mode support.
/// </summary>
public class AlternatingRowColorConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        bool isDarkMode = Application.Current?.RequestedTheme == AppTheme.Dark;

        if (value is int index)
        {
            if (isDarkMode)
            {
                return index % 2 == 0 ? Color.FromArgb("#1E1E1E") : Color.FromArgb("#2A2A2A");
            }
            return index % 2 == 0 ? Colors.White : Color.FromArgb("#F5F5F5");
        }
        return isDarkMode ? Color.FromArgb("#1E1E1E") : Colors.White;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// Converter for completed task text color and indicator color with Light/Dark mode support.
/// </summary>
public class CompletedToColorConverter : IValueConverter
{
    // Light theme colors
    private static readonly Color AccentColorLight = Color.FromArgb("#26A69A");
    private static readonly Color AccentColorDark = Color.FromArgb("#4DB6AC");
    private static readonly Color CompletedColor = Color.FromArgb("#9E9E9E");
    private static readonly Color TextPrimaryLight = Color.FromArgb("#212121");
    private static readonly Color TextSecondaryLight = Color.FromArgb("#757575");

    // Dark theme colors
    private static readonly Color TextPrimaryDark = Color.FromArgb("#FFFFFF");
    private static readonly Color TextSecondaryDark = Color.FromArgb("#B0B0B0");

    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        bool isCompleted = value is bool b && b;
        string param = parameter as string ?? "";
        bool isDarkMode = Application.Current?.RequestedTheme == AppTheme.Dark;

        // Indicator bar color - theme-aware accent color
        if (param == "indicator")
        {
            var color = isCompleted ? CompletedColor : (isDarkMode ? AccentColorDark : AccentColorLight);
            Console.WriteLine($"[CompletedToColorConverter] indicator: isCompleted={isCompleted}, isDarkMode={isDarkMode}, color={color}");
            return color;
        }

        // Text colors with theme support
        if (isCompleted)
        {
            return CompletedColor;
        }
        else
        {
            if (param == "notes")
            {
                return isDarkMode ? TextSecondaryDark : TextSecondaryLight;
            }
            return isDarkMode ? TextPrimaryDark : TextPrimaryLight;
        }
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// Converter for completed task text decorations (strikethrough).
/// </summary>
public class CompletedToTextDecorationsConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        bool isCompleted = value is bool b && b;
        return isCompleted ? TextDecorations.Strikethrough : TextDecorations.None;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// Converter for completed task opacity (slightly faded when complete).
/// </summary>
public class CompletedToOpacityConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        bool isCompleted = value is bool b && b;
        return isCompleted ? 0.7 : 1.0;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

