using Microsoft.Maui.Hosting;
using Microsoft.Maui.Platform.Linux.Hosting;
using Microsoft.Maui.Platform.Linux.Blazor.Hosting;

namespace BlazorDemo;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseLinux()
            .UseLinuxBlazorWebView();   // Blazor WebView services + WPE-backed handler

        builder.Services.AddSingleton<WeatherService>();
        return builder.Build();
    }
}
