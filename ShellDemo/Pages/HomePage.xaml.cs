// HomePage - Welcome page for the demo

using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Platform.Linux.Hosting;

namespace ShellDemo;

public partial class HomePage : ContentPage
{
    private bool _isUpdatingThemeSwitch;

    public HomePage()
    {
        InitializeComponent();
        CreateFeatureCards();
        UpdateThemeSwitchState();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        UpdateThemeSwitchState();
    }

    private void UpdateThemeSwitchState()
    {
        _isUpdatingThemeSwitch = true;
        var isDark = Application.Current?.UserAppTheme == AppTheme.Dark ||
                    (Application.Current?.UserAppTheme == AppTheme.Unspecified &&
                     Application.Current?.RequestedTheme == AppTheme.Dark);
        ThemeSwitch.IsToggled = isDark;
        _isUpdatingThemeSwitch = false;
    }

    private void OnThemeSwitchToggled(object? sender, ToggledEventArgs e)
    {
        if (_isUpdatingThemeSwitch || Application.Current == null) return;

        Application.Current.UserAppTheme = e.Value ? AppTheme.Dark : AppTheme.Light;
    }

    private void CreateFeatureCards()
    {
        // Title, Description, Route
        var features = new[]
        {
            ("Buttons", "Various button styles and events", "Buttons"),
            ("Text Input", "Entry, Editor, SearchBar", "TextInput"),
            ("Selection", "CheckBox, Switch, Slider", "Selection"),
            ("Pickers", "Picker, DatePicker, TimePicker", "Pickers"),
            ("Lists", "CollectionView with selection", "Lists"),
            ("Progress", "ProgressBar, ActivityIndicator", "Progress")
        };

        for (int i = 0; i < features.Length; i++)
        {
            var (title, desc, route) = features[i];
            var card = CreateFeatureCard(title, desc, route);
            Grid.SetRow(card, i / 2);
            Grid.SetColumn(card, i % 2);
            FeatureGrid.Children.Add(card);
        }
    }

    private Border CreateFeatureCard(string title, string description, string route)
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

        // Add tap gesture for navigation
        var tapGesture = new TapGestureRecognizer();
        tapGesture.Tapped += (s, e) => LinuxViewRenderer.NavigateToRoute(route);
        border.GestureRecognizers.Add(tapGesture);

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
