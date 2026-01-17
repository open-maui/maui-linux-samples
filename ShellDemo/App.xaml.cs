// App.xaml.cs - Main Application code-behind

using Microsoft.Maui.Controls;

namespace ShellDemo;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new AppShell());
    }
}
