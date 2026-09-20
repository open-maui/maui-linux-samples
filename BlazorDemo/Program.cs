using Microsoft.Maui.Platform.Linux;

namespace BlazorDemo;

class Program
{
    static void Main(string[] args)
    {
        AppDomain.CurrentDomain.UnhandledException += (_, e) =>
        {
            var ex = e.ExceptionObject as Exception;
            Console.WriteLine($"[FATAL] {ex?.GetType().Name}: {ex?.Message}\n{ex?.StackTrace}");
        };
        TaskScheduler.UnobservedTaskException += (_, e) =>
        {
            Console.WriteLine($"[FATAL] Unobserved: {e.Exception?.GetBaseException().Message}");
            e.SetObserved();
        };

        var app = MauiProgram.CreateMauiApp();
        // BlazorWebView on Linux is WPE-backed and runs in native Wayland/X11 mode.
        LinuxApplication.Run(app, args);
    }
}
