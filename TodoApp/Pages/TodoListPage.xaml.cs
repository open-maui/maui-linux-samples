// TodoListPage - Main page for viewing todos with XAML support

using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using System.Globalization;

namespace TodoApp;

public partial class TodoListPage : ContentPage
{
    private readonly TodoService _service = TodoService.Instance;

    public TodoListPage()
    {
        Console.WriteLine("[TodoListPage] Constructor starting");
        InitializeComponent();

        TodoCollectionView.ItemsSource = _service.Todos;
        UpdateStats();

        Console.WriteLine("[TodoListPage] Constructor finished");
    }

    protected override void OnAppearing()
    {
        Console.WriteLine("[TodoListPage] OnAppearing called - refreshing CollectionView");
        base.OnAppearing();

        // Refresh indexes for alternating row colors
        _service.RefreshIndexes();

        // Refresh the collection view
        TodoCollectionView.ItemsSource = null;
        TodoCollectionView.ItemsSource = _service.Todos;
        Console.WriteLine($"[TodoListPage] ItemsSource set with {_service.Todos.Count} items");
        UpdateStats();
    }

    private async void OnAddClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewTodoPage());
    }

    private async void OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        try
        {
            Console.WriteLine($"[TodoListPage] OnSelectionChanged: {e.CurrentSelection.Count} items selected");
            if (e.CurrentSelection.FirstOrDefault() is TodoItem todo)
            {
                Console.WriteLine($"[TodoListPage] Navigating to TodoDetailPage for: {todo.Title}");
                TodoCollectionView.SelectedItem = null; // Deselect
                var detailPage = new TodoDetailPage(todo);
                Console.WriteLine($"[TodoListPage] Created TodoDetailPage, pushing...");
                await Navigation.PushAsync(detailPage);
                Console.WriteLine($"[TodoListPage] Navigation complete");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[TodoListPage] EXCEPTION in OnSelectionChanged: {ex.GetType().Name}: {ex.Message}");
            Console.WriteLine($"[TodoListPage] Stack trace: {ex.StackTrace}");
        }
    }

    private void UpdateStats()
    {
        var completed = _service.CompletedCount;
        var total = _service.TotalCount;

        if (total == 0)
        {
            StatsLabel.Text = "";
        }
        else
        {
            StatsLabel.Text = $"{completed} of {total} completed";
        }
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
    private static readonly Color AccentColor = Color.FromArgb("#26A69A");
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

        // Indicator bar color
        if (param == "indicator")
        {
            return isCompleted ? CompletedColor : AccentColor;
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
