// MauiProgram.cs - MAUI app configuration

using CommunityToolkit.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Platform.Linux.Hosting;
using Microsoft.Maui.Platform.Linux.MediaElement.Hosting;

namespace MediaDemo;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()
            // false: skip Android foreground-service registration (Linux/desktop don't need it).
            .UseMauiCommunityToolkitMediaElement(isAndroidForegroundServiceEnabled: false)
            .UseLinux()                              // base Linux handlers
            .UseLinuxMediaElement();                 // opt-in Linux MediaElement backend (GStreamer)

        return builder.Build();
    }
}
