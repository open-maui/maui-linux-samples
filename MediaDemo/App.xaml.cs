using Microsoft.Maui.Controls;

namespace MediaDemo;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new Pages.MediaPage())
        {
            Title = "OpenMaui Media Demo",
            Width = 1024,
            Height = 720,
        };
    }
}
