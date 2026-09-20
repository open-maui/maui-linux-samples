using Microsoft.AspNetCore.Components.WebView;
using Microsoft.Maui.Controls;

namespace BlazorDemo;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnBlazorInitialized(object? sender, BlazorWebViewInitializedEventArgs e)
    {
        StatusLabel.Text = "Blazor: initialized";
    }

    private void OnUrlLoading(object? sender, UrlLoadingEventArgs e)
    {
        // External links open in the system browser by default; log the decision.
        Console.WriteLine($"[BlazorDemo] UrlLoading {e.Url} -> {e.UrlLoadingStrategy}");
    }
}
