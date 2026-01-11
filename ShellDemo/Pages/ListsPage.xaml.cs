// ListsPage - CollectionView and ListView Demo

using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace ShellDemo;

public partial class ListsPage : ContentPage
{
    private int _eventCount = 0;
    private ObservableCollection<string> _contacts;

    public ListsPage()
    {
        InitializeComponent();

        // Set up fruits
        var fruits = new List<string>
        {
            "Apple", "Banana", "Cherry", "Date", "Elderberry",
            "Fig", "Grape", "Honeydew", "Kiwi", "Lemon",
            "Mango", "Nectarine", "Orange", "Papaya", "Quince"
        };
        FruitsCollectionView.ItemsSource = fruits;

        // Set up colors
        var colors = new List<string>
        {
            "Red", "Pink", "Purple", "Deep Purple", "Indigo",
            "Blue", "Cyan", "Teal", "Green", "Light Green",
            "Lime", "Yellow", "Amber", "Orange", "Deep Orange"
        };
        ColorsCollectionView.ItemsSource = colors;

        // Set up contacts
        _contacts = new ObservableCollection<string>
        {
            "Alice Johnson (Engineering)",
            "Bob Smith (Marketing)",
            "Carol Williams (Design)",
            "David Brown (Sales)",
            "Eva Martinez (Engineering)",
            "Frank Lee (Support)",
            "Grace Kim (HR)",
            "Henry Wilson (Finance)"
        };
        ContactsCollectionView.ItemsSource = _contacts;
    }

    private void OnFruitsSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count > 0)
        {
            var item = e.CurrentSelection[0]?.ToString();
            FruitsSelectedLabel.Text = $"Selected: {item}";
            LogEvent($"Fruit selected: {item}");
        }
    }

    private void OnColorsSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count > 0)
        {
            var item = e.CurrentSelection[0]?.ToString();
            LogEvent($"Color selected: {item}");
        }
    }

    private void OnContactsSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count > 0)
        {
            var contact = e.CurrentSelection[0]?.ToString();
            LogEvent($"Contact: {contact}");
        }
    }

    private void OnAddContactClicked(object? sender, EventArgs e)
    {
        var newContact = $"New Contact {_contacts.Count + 1} (New)";
        _contacts.Add(newContact);
        LogEvent($"Added: {newContact}");
    }

    private void OnDeleteContactClicked(object? sender, EventArgs e)
    {
        if (ContactsCollectionView.SelectedItem is string selected && _contacts.Contains(selected))
        {
            _contacts.Remove(selected);
            LogEvent($"Deleted: {selected}");
        }
        else
        {
            LogEvent("No contact selected to delete");
        }
    }

    private void LogEvent(string message)
    {
        _eventCount++;
        var timestamp = DateTime.Now.ToString("HH:mm:ss");
        EventLogLabel.Text = $"[{timestamp}] {_eventCount}. {message}\n{EventLogLabel.Text}";
    }
}
