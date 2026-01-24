// AboutPage - Information about OpenMaui Linux

using Microsoft.Maui.Controls;

namespace ShellDemo;

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent();
    }

    private async void OnWebsiteLinkTapped(object? sender, TappedEventArgs e)
    {
        try
        {
            await Microsoft.Maui.Platform.Linux.Services.Browser.OpenAsync("https://www.openmaui.net", BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to open URL: {ex.Message}");
        }
    }
}
