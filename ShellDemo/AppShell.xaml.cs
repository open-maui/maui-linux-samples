// AppShell - Shell navigation with flyout menu

using Microsoft.Maui.Controls;

namespace ShellDemo;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Register routes for push navigation (pages not in flyout)
        Routing.RegisterRoute("detail", typeof(DetailPage));
    }
}
