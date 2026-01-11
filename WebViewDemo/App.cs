// App.cs - Main Application with NavigationPage

using Microsoft.Maui.Controls;

namespace WebViewDemo;

public class App : Application
{
    public static NavigationPage? NavigationPage { get; private set; }

    public App()
    {
        NavigationPage = new NavigationPage(new WebViewPage())
        {
            Title = "OpenMaui WebView Demo",
            BarBackgroundColor = Color.FromArgb("#5C6BC0"),
            BarTextColor = Colors.White
        };
        MainPage = NavigationPage;
    }
}
