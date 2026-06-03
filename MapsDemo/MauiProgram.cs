// MauiProgram.cs - MAUI app configuration

using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Platform.Linux.Hosting;
using Microsoft.Maui.Platform.Linux.Maps.Hosting;

namespace MapsDemo;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()
            .UseMauiMaps()       // upstream MAUI Maps registration
            .UseLinux()          // base Linux handlers
            .UseLinuxMaps();     // opt-in Linux Maps backend (OSM tiles via Skia)

        return builder.Build();
    }
}
