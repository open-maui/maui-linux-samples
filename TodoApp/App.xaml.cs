// TodoApp - Main Application with NavigationPage and Theme Support

using Microsoft.Maui.Controls;

namespace TodoApp;

public partial class App : Application
{
    public static NavigationPage? NavigationPage { get; private set; }

    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        // Determine current theme for navigation bar colors
        var isDarkMode = Current?.RequestedTheme == AppTheme.Dark;
        var barBackground = isDarkMode ? Color.FromArgb("#3949AB") : Color.FromArgb("#5C6BC0");

        NavigationPage = new NavigationPage(new TodoListPage())
        {
            Title = "OpenMaui Todo App",
            BarBackgroundColor = barBackground,
            BarTextColor = Colors.White
        };

        // Update navigation bar when theme changes
        Current!.RequestedThemeChanged += (s, e) =>
        {
            var dark = e.RequestedTheme == AppTheme.Dark;
            NavigationPage.BarBackgroundColor = dark ? Color.FromArgb("#3949AB") : Color.FromArgb("#5C6BC0");
        };

        return new Window(NavigationPage);
    }
}
