// HomePage - Welcome page for the demo

using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Platform.Linux.Hosting;

namespace ShellDemo;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
        CreateFeatureCards();
    }

    private void CreateFeatureCards()
    {
        var features = new[]
        {
            ("Buttons", "Various button styles and events"),
            ("Text Input", "Entry, Editor, SearchBar"),
            ("Selection", "CheckBox, Switch, Slider"),
            ("Pickers", "Picker, DatePicker, TimePicker"),
            ("Lists", "CollectionView with selection"),
            ("Progress", "ProgressBar, ActivityIndicator")
        };

        for (int i = 0; i < features.Length; i++)
        {
            var (title, desc) = features[i];
            var card = CreateFeatureCard(title, desc);
            Grid.SetRow(card, i / 2);
            Grid.SetColumn(card, i % 2);
            FeatureGrid.Children.Add(card);
        }
    }

    private Border CreateFeatureCard(string title, string description)
    {
        // Use AppThemeBinding for card colors
        var cardBackground = new AppThemeBindingExtension
        {
            Light = Application.Current?.Resources["CardBackgroundLight"] as Color ?? Colors.White,
            Dark = Application.Current?.Resources["CardBackgroundDark"] as Color ?? Color.FromArgb("#1E1E1E")
        };

        var textPrimary = new AppThemeBindingExtension
        {
            Light = Application.Current?.Resources["TextPrimaryLight"] as Color ?? Colors.Black,
            Dark = Application.Current?.Resources["TextPrimaryDark"] as Color ?? Colors.White
        };

        var textSecondary = new AppThemeBindingExtension
        {
            Light = Application.Current?.Resources["TextSecondaryLight"] as Color ?? Colors.Gray,
            Dark = Application.Current?.Resources["TextSecondaryDark"] as Color ?? Color.FromArgb("#B0B0B0")
        };

        var titleLabel = new Label
        {
            Text = title,
            FontSize = 14,
            FontAttributes = FontAttributes.Bold,
            TextColor = Color.FromArgb("#2196F3")
        };

        var descLabel = new Label
        {
            Text = description,
            FontSize = 11,
            LineBreakMode = LineBreakMode.WordWrap
        };
        descLabel.SetBinding(Label.TextColorProperty, new Binding { Source = textSecondary, Path = "." });
        descLabel.SetAppThemeColor(Label.TextColorProperty,
            Application.Current?.Resources["TextSecondaryLight"] as Color ?? Colors.Gray,
            Application.Current?.Resources["TextSecondaryDark"] as Color ?? Color.FromArgb("#B0B0B0"));

        var border = new Border
        {
            Padding = new Thickness(15),
            StrokeThickness = 0,
            StrokeShape = new RoundRectangle { CornerRadius = 8 },
            Shadow = new Shadow
            {
                Brush = new SolidColorBrush(Colors.Black),
                Opacity = 0.1f,
                Radius = 4,
                Offset = new Point(0, 2)
            },
            Content = new VerticalStackLayout
            {
                Spacing = 5,
                Children = { titleLabel, descLabel }
            }
        };

        border.SetAppThemeColor(Border.BackgroundColorProperty,
            Application.Current?.Resources["CardBackgroundLight"] as Color ?? Colors.White,
            Application.Current?.Resources["CardBackgroundDark"] as Color ?? Color.FromArgb("#1E1E1E"));

        return border;
    }

    private void OnTryButtonsClicked(object? sender, EventArgs e)
    {
        LinuxViewRenderer.NavigateToRoute("Buttons");
    }

    private void OnTryListsClicked(object? sender, EventArgs e)
    {
        LinuxViewRenderer.NavigateToRoute("Lists");
    }

    private void OnPushDetailClicked(object? sender, EventArgs e)
    {
        Console.WriteLine("[HomePage] Push button clicked, navigating to detail");
        var success = LinuxViewRenderer.PushPage(new DetailPage());
        Console.WriteLine($"[HomePage] PushPage result: {success}");
    }
}
