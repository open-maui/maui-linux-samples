// TextInputPage - Demonstrates text input controls

using Microsoft.Maui.Controls;

namespace ShellDemo;

public partial class TextInputPage : ContentPage
{
    public TextInputPage()
    {
        InitializeComponent();
    }

    private void OnNameEntryTextChanged(object? sender, TextChangedEventArgs e)
    {
        EntryOutputLabel.Text = $"You typed: {e.NewTextValue}";
    }

    private void OnSearchBarTextChanged(object? sender, TextChangedEventArgs e)
    {
        SearchOutputLabel.Text = $"Searching: {e.NewTextValue}";
    }

    private void OnSearchButtonPressed(object? sender, EventArgs e)
    {
        SearchOutputLabel.Text = $"Search submitted: {MainSearchBar.Text}";
    }

    private void OnEditorTextChanged(object? sender, TextChangedEventArgs e)
    {
        var lineCount = string.IsNullOrEmpty(e.NewTextValue) ? 0 : e.NewTextValue.Split('\n').Length;
        EditorOutputLabel.Text = $"Lines: {lineCount}, Characters: {e.NewTextValue?.Length ?? 0}";
    }
}
