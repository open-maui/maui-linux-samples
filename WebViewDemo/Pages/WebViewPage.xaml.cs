// WebViewPage - Main page demonstrating WebView with WebKitGTK

using Microsoft.Maui.Controls;

namespace WebViewDemo;

public partial class WebViewPage : ContentPage
{
    public WebViewPage()
    {
        Console.WriteLine("[WebViewPage] Constructor starting");
        InitializeComponent();

        // Set initial URL
        MainWebView.Source = new UrlWebViewSource { Url = "https://dotnet.microsoft.com" };

        Console.WriteLine("[WebViewPage] Constructor finished");
    }

    private void OnBackClicked(object? sender, EventArgs e)
    {
        Console.WriteLine("[WebViewPage] Back button clicked");
        if (MainWebView.CanGoBack)
        {
            MainWebView.GoBack();
        }
    }

    private void OnForwardClicked(object? sender, EventArgs e)
    {
        Console.WriteLine("[WebViewPage] Forward button clicked");
        if (MainWebView.CanGoForward)
        {
            MainWebView.GoForward();
        }
    }

    private void OnReloadClicked(object? sender, EventArgs e)
    {
        Console.WriteLine("[WebViewPage] Reload button clicked");
        MainWebView.Reload();
    }

    private void OnGoClicked(object? sender, EventArgs e)
    {
        Navigate();
    }

    private void OnUrlSubmitted(object? sender, EventArgs e)
    {
        Navigate();
    }

    private void Navigate()
    {
        var url = UrlEntry.Text?.Trim();
        if (string.IsNullOrEmpty(url))
            return;

        // Add https:// if not present
        if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            url = "https://" + url;

        Console.WriteLine($"[WebViewPage] Navigating to: {url}");
        MainWebView.Source = new UrlWebViewSource { Url = url };
        UrlEntry.Text = url;
    }

    private void OnNavigating(object? sender, WebNavigatingEventArgs e)
    {
        StatusLabel.Text = $"Loading: {e.Url}";
        Console.WriteLine($"[WebViewPage] Navigating to: {e.Url}");
    }

    private void OnNavigated(object? sender, WebNavigatedEventArgs e)
    {
        StatusLabel.Text = e.Result == WebNavigationResult.Success
            ? $"Loaded: {e.Url}"
            : $"Failed: {e.Result}";

        UrlEntry.Text = e.Url;
        Console.WriteLine($"[WebViewPage] Navigated: {e.Result} - {e.Url}");
    }

    private void OnLoadHtmlClicked(object? sender, EventArgs e)
    {
        Console.WriteLine("[WebViewPage] Load HTML button clicked");

        var html = @"
<!DOCTYPE html>
<html>
<head>
    <title>OpenMaui WebView</title>
    <style>
        body {
            font-family: 'Segoe UI', Arial, sans-serif;
            margin: 40px;
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            color: white;
            min-height: 100vh;
        }
        h1 {
            font-size: 2.5em;
            margin-bottom: 20px;
        }
        p {
            font-size: 1.2em;
            line-height: 1.6;
        }
        .feature-list {
            background: rgba(255,255,255,0.1);
            padding: 20px;
            border-radius: 10px;
            margin-top: 20px;
        }
        li {
            margin: 10px 0;
            font-size: 1.1em;
        }
        button {
            background: #4CAF50;
            color: white;
            border: none;
            padding: 15px 30px;
            font-size: 1.1em;
            border-radius: 5px;
            cursor: pointer;
            margin-top: 20px;
        }
        button:hover {
            background: #45a049;
        }
    </style>
</head>
<body>
    <h1>Hello from OpenMaui Linux!</h1>
    <p>This HTML content is rendered by WebKitGTK inside your .NET MAUI application.</p>

    <div class='feature-list'>
        <h2>WebView Features:</h2>
        <ul>
            <li>Full HTML5 support</li>
            <li>CSS3 animations and transitions</li>
            <li>JavaScript execution</li>
            <li>Navigation history (back/forward)</li>
            <li>WebGL and canvas support</li>
        </ul>
    </div>

    <button onclick=""alert('Hello from JavaScript!')"">Click Me!</button>

    <p style='margin-top: 30px; opacity: 0.8;'>
        Powered by WebKitGTK - the same engine used by GNOME Web (Epiphany)
    </p>
</body>
</html>";

        MainWebView.Source = new HtmlWebViewSource { Html = html };
        StatusLabel.Text = "Loaded custom HTML";
    }

    private async void OnEvalJsClicked(object? sender, EventArgs e)
    {
        Console.WriteLine("[WebViewPage] Run JS button clicked");

        try
        {
            var result = await MainWebView.EvaluateJavaScriptAsync("document.title");
            StatusLabel.Text = $"JS Result: {result ?? "(null)"}";
            Console.WriteLine($"[WebViewPage] JS Eval result: {result}");
        }
        catch (Exception ex)
        {
            StatusLabel.Text = $"JS Error: {ex.Message}";
            Console.WriteLine($"[WebViewPage] JS Error: {ex.Message}");
        }
    }
}
