// AppShell - Shell navigation with flyout menu

using System.Reflection;
using Microsoft.Maui.Controls;

namespace ShellDemo;

public partial class AppShell : Shell
{
    public string AppVersion { get; }

    public AppShell()
    {
        // Get app version from assembly
        var version = Assembly.GetExecutingAssembly().GetName().Version;
        AppVersion = $"OpenMaui v{version?.Major ?? 1}.{version?.Minor ?? 0}.{version?.Build ?? 0}";

        BindingContext = this;

        InitializeComponent();

        // Register routes for push navigation (pages not in flyout)
        Routing.RegisterRoute("detail", typeof(DetailPage));
    }
}
