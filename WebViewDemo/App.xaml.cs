// App.xaml.cs - Main Application with Theme Support

using Microsoft.Maui.Controls;

namespace WebViewDemo;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new WebViewPage())
        {
            Title = "OpenMaui Browser"
        };
    }

    public static void ToggleTheme()
    {
        if (Current is null) return;

        Current.UserAppTheme = Current.UserAppTheme == AppTheme.Dark
            ? AppTheme.Light
            : AppTheme.Dark;
    }
}
