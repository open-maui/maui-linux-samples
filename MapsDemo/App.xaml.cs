using Microsoft.Maui.Controls;

namespace MapsDemo;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new Pages.MapsPage())
        {
            Title = "OpenMaui Maps Demo",
            Width = 1024,
            Height = 720,
        };
    }
}
