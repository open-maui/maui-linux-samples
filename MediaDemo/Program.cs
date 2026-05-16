// Program.cs - Linux platform entry point

using Microsoft.Maui.Platform.Linux;

namespace MediaDemo;

class Program
{
    static void Main(string[] args)
    {
        var logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "mediademo.log");
        using var logWriter = new StreamWriter(logPath, append: false) { AutoFlush = true };
        var multiWriter = new MultiTextWriter(Console.Out, logWriter);
        Console.SetOut(multiWriter);
        Console.SetError(multiWriter);

        AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
        {
            var ex = e.ExceptionObject as Exception;
            Console.WriteLine($"[FATAL] Unhandled exception: {ex?.GetType().Name}: {ex?.Message}");
            Console.WriteLine($"[FATAL] Stack trace: {ex?.StackTrace}");
        };

        TaskScheduler.UnobservedTaskException += (sender, e) =>
        {
            Console.WriteLine($"[FATAL] Unobserved task exception: {e.Exception?.Message}");
            e.SetObserved();
        };

        Console.WriteLine($"[Program] Starting Media Demo at {DateTime.Now}");
        Console.WriteLine($"[Program] Log file: {logPath}");

        try
        {
            var app = MauiProgram.CreateMauiApp();
            LinuxApplication.Run(app, args);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[FATAL] Exception in Main: {ex.GetType().Name}: {ex.Message}");
            Console.WriteLine($"[FATAL] Stack trace: {ex.StackTrace}");
            throw;
        }
    }
}

class MultiTextWriter : TextWriter
{
    private readonly TextWriter[] _writers;
    public MultiTextWriter(params TextWriter[] writers) => _writers = writers;
    public override System.Text.Encoding Encoding => System.Text.Encoding.UTF8;
    public override void Write(char value) { foreach (var w in _writers) w.Write(value); }
    public override void WriteLine(string? value) { foreach (var w in _writers) w.WriteLine(value); }
    public override void Flush() { foreach (var w in _writers) w.Flush(); }
}
