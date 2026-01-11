// DetailPage - Demonstrates push/pop navigation

using Microsoft.Maui.Controls;
using Microsoft.Maui.Platform.Linux.Hosting;

namespace ShellDemo;

/// <summary>
/// A detail page that can be pushed onto the navigation stack.
/// </summary>
public partial class DetailPage : ContentPage
{
    private readonly string _itemName;

    public DetailPage() : this("Detail Item")
    {
    }

    public DetailPage(string itemName)
    {
        _itemName = itemName;
        InitializeComponent();
        ItemNameLabel.Text = $"You navigated to: {_itemName}";
    }

    private void OnBackClicked(object? sender, EventArgs e)
    {
        Console.WriteLine("[DetailPage] Go Back clicked");
        var success = LinuxViewRenderer.PopPage();
        Console.WriteLine($"[DetailPage] PopPage result: {success}");
    }
}

/// <summary>
/// Query property for passing data to DetailPage.
/// </summary>
[QueryProperty(nameof(ItemName), "item")]
public class DetailPageWithQuery : DetailPage
{
    private string _itemName = "Item";

    public string ItemName
    {
        get => _itemName;
        set
        {
            _itemName = value;
            Title = $"Detail: {value}";
        }
    }

    public DetailPageWithQuery() : base()
    {
    }
}
