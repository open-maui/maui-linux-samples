# OpenMaui Linux Samples

Sample applications demonstrating [OpenMaui Linux](https://git.marketally.com/open-maui/maui-linux) - .NET MAUI on Linux desktop with SkiaSharp rendering.

## Table of Contents

- [Overview](#overview)
- [Sample Applications](#sample-applications)
- [Requirements](#requirements)
- [Installation](#installation)
- [Quick Start](#quick-start)
- [Building and Deployment](#building-and-deployment)
- [Sample Details](#sample-details)
  - [TodoApp](#todoapp)
  - [ShellDemo](#shelldemo)
  - [WebViewDemo](#webviewdemo)
- [Project Structure](#project-structure)
- [Development Guide](#development-guide)
- [API Usage Examples](#api-usage-examples)
- [Related Resources](#related-resources)
- [License](#license)

## Overview

This repository contains production-ready sample applications showcasing **OpenMaui Linux** - a .NET MAUI implementation for Linux desktop environments. These samples demonstrate how to build cross-platform applications using familiar MAUI APIs with native Linux rendering via SkiaSharp and optional GTK integration.

**Key Features:**
- Full .NET MAUI API compatibility
- SkiaSharp-based rendering for high-performance graphics
- X11 window management support
- GTK integration for WebView and native dialogs
- Light/Dark theme support with dynamic switching
- Navigation (NavigationPage, Shell, push/pop)
- Data binding and MVVM patterns
- Comprehensive control coverage

## Sample Applications

| Sample | Description | Key Features |
|--------|-------------|--------------|
| [TodoApp](./TodoApp/) | Full-featured task manager | NavigationPage, XAML data binding, CollectionView, value converters, theme switching |
| [ShellDemo](./ShellDemo/) | Comprehensive control showcase | Shell navigation, flyout menu, all core controls, event logging |
| [WebViewDemo](./WebViewDemo/) | Web browser with WebKitGTK | WebView, JavaScript evaluation, GTK integration, HTML rendering |

## Requirements

**Software:**
- .NET 10.0 SDK or later
- Linux with X11 display server (Wayland not yet supported)
- Supported distributions: Ubuntu 20.04+, Fedora 35+, Debian 11+, or similar

**System Dependencies:**
```bash
# Ubuntu/Debian
sudo apt-get install libfontconfig1-dev libfreetype6-dev

# Fedora/RHEL
sudo dnf install fontconfig-devel freetype-devel

# For WebView support (WebViewDemo)
sudo apt-get install libwebkit2gtk-4.0-dev  # Ubuntu/Debian
sudo dnf install webkit2gtk3-devel          # Fedora/RHEL
```

## Installation

### Clone the Repository

```bash
git clone https://git.marketally.com/open-maui/maui-linux-samples.git
cd maui-linux-samples
```

### Install .NET SDK

If you don't have .NET 10.0 SDK installed:

```bash
# Download and install .NET SDK
wget https://dot.net/v1/dotnet-install.sh
chmod +x dotnet-install.sh
./dotnet-install.sh --channel 10.0

# Add to PATH (add to ~/.bashrc for persistence)
export DOTNET_ROOT=$HOME/.dotnet
export PATH=$DOTNET_ROOT:$PATH
```

### Verify Installation

```bash
dotnet --version  # Should show 10.0.x or later
```

## Quick Start

### Run TodoApp

```bash
cd TodoApp
dotnet run
```

The todo application will launch with sample tasks. You can:
- Add new tasks with the "+" button
- Tap tasks to view/edit details
- Mark tasks as completed
- Delete tasks
- Toggle between light and dark themes

### Run ShellDemo

```bash
cd ../ShellDemo
dotnet run
```

The control gallery will open with a flyout menu. Navigate through different pages to explore:
- Button styles and events
- Text input controls (Entry, Editor, SearchBar)
- Selection controls (CheckBox, Switch, Slider)
- Pickers (Picker, DatePicker, TimePicker)
- CollectionView with dynamic data
- Progress indicators
- Grid layouts with various configurations

### Run WebViewDemo

```bash
cd ../WebViewDemo
dotnet run
```

A web browser window will open. You can:
- Navigate to any URL
- Use back/forward buttons
- Load custom HTML content
- Execute JavaScript
- Toggle themes

## Building and Deployment

### Debug Build

```bash
# Build without running
dotnet build

# Output location: bin/Debug/net10.0/
```

### Release Build

```bash
# Build optimized release version
dotnet build -c Release
```

### Publish for Distribution

Create self-contained executables for specific Linux architectures:

```bash
# Linux x64 (most desktops)
dotnet publish -c Release -r linux-x64 --self-contained

# Linux ARM64 (Raspberry Pi, ARM servers)
dotnet publish -c Release -r linux-arm64 --self-contained

# Framework-dependent (requires .NET runtime installed)
dotnet publish -c Release -r linux-x64 --no-self-contained
```

Published applications will be in `bin/Release/net10.0/linux-x64/publish/` and can be distributed as standalone executables.

### Create Desktop Launcher

```bash
# Make the run script executable
chmod +x TodoApp/run.sh

# Create a .desktop file for your application
cat > ~/.local/share/applications/openmaui-todo.desktop << EOF
[Desktop Entry]
Type=Application
Name=OpenMaui Todo
Exec=/path/to/maui-linux-samples/TodoApp/run.sh
Icon=utilities-terminal
Terminal=false
Categories=Utility;
EOF
```

## Sample Details

### TodoApp

A complete task management application demonstrating production-ready patterns.

**Features:**
- **NavigationPage** with toolbar and back navigation
- **CollectionView** with item selection and data templates
- **XAML data binding** with INotifyPropertyChanged
- **Value converters** for dynamic styling (alternating rows, completed tasks)
- **DisplayAlert** dialogs for confirmations
- **Theme switching** (Light/Dark) with AppThemeBinding
- **Grid layouts** with star sizing
- **Entry and Editor** for text input
- **Alternating row colors** with theme support

**Architecture:**
- `TodoItem.cs` - Data model with property change notifications
- `TodoService.cs` - Business logic with ObservableCollection
- `TodoListPage.xaml` - Main list view with data templates
- `TodoDetailPage.xaml` - Detail/edit view
- `NewTodoPage.xaml` - Create new task view
- Value converters for visual state management

**Code Example - Data Binding:**

```xaml
<!-- TodoListPage.xaml -->
<CollectionView ItemsSource="{Binding Todos}" SelectionMode="Single">
    <CollectionView.ItemTemplate>
        <DataTemplate>
            <Grid Padding="15,10" 
                  BackgroundColor="{Binding Index, Converter={StaticResource AlternatingRowColorConverter}}">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="4"/>
                    <ColumnDefinition Width="*"/>
                </Grid.ColumnDefinitions>
                
                <!-- Status indicator -->
                <BoxView Grid.Column="0" 
                         BackgroundColor="{Binding IsCompleted, Converter={StaticResource CompletedToColorConverter}, ConverterParameter=indicator}"/>
                
                <!-- Task content -->
                <VerticalStackLayout Grid.Column="1" Spacing="4">
                    <Label Text="{Binding Title}" 
                           FontSize="16"
                           TextColor="{Binding IsCompleted, Converter={StaticResource CompletedToColorConverter}}"
                           TextDecorations="{Binding IsCompleted, Converter={StaticResource CompletedToTextDecorationsConverter}}"/>
                    <Label Text="{Binding Notes}" 
                           FontSize="12"
                           MaxLines="2"
                           LineBreakMode="TailTruncation"
                           TextColor="{Binding IsCompleted, Converter={StaticResource CompletedToColorConverter}, ConverterParameter=notes}"/>
                </VerticalStackLayout>
            </Grid>
        </DataTemplate>
    </CollectionView.ItemTemplate>
</CollectionView>
```

**Logging:**
Application logs are written to `~/todoapp.log` for debugging.

### ShellDemo

A comprehensive control gallery showcasing all supported MAUI controls with Shell navigation.

**Features:**
- **Shell navigation** with flyout menu
- **All core controls**: Button, Entry, Editor, SearchBar, CheckBox, Switch, Slider, Stepper
- **Pickers**: Picker, DatePicker, TimePicker
- **CollectionView** with various data types and selection modes
- **ProgressBar and ActivityIndicator**
- **Grid layouts** with demonstrations of:
  - Auto, Star, and Absolute sizing
  - Row and column spanning
  - Spacing and padding
  - Mixed sizing strategies
- **Real-time event logging** for all interactions
- **Push/pop navigation** examples
- **Theme switching** support

**Navigation Structure:**

```csharp
// AppShell.xaml.cs - Shell with flyout menu
public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        
        // Register routes for push navigation
        Routing.RegisterRoute("detail", typeof(DetailPage));
    }
}
```

**Code Example - Grid Layouts:**

```csharp
// GridsPage.xaml.cs - Programmatic grid creation
private View CreateStarSizingDemo()
{
    var grid = new Grid
    {
        ColumnDefinitions =
        {
            new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
            new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) },
            new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
        }
    };
    
    // Add cells with proportional sizing: 25% | 50% | 25%
    grid.Children.Add(CreateCell("1*", "#BBDEFB"));
    grid.Children.Add(CreateCell("2* (double)", "#C8E6C9"));
    grid.Children.Add(CreateCell("1*", "#FFECB3"));
    
    return grid;
}
```

**Logging:**
Application logs are written to `~/shelldemo.log` for debugging.

### WebViewDemo

A web browser application demonstrating WebView integration with WebKitGTK.

**Features:**
- **WebView** with full HTML5 support
- **WebKitGTK** backend (same engine as GNOME Web)
- **Navigation controls** (back, forward, reload)
- **URL entry** with automatic https:// prefix
- **JavaScript evaluation** via `EvaluateJavaScriptAsync`
- **HTML content loading** from strings
- **Progress indicator** with animations
- **Theme switching** support
- **GTK mode** for native WebView rendering

**Important:** Requires GTK mode enabled in `Program.cs`:

```csharp
// WebViewDemo/Program.cs
LinuxApplication.Run(app, args, options =>
{
    options.UseGtk = true;  // Required for WebView
});
```

**Code Example - JavaScript Evaluation:**

```csharp
private async void OnEvalJsClicked(object? sender, EventArgs e)
{
    try
    {
        var result = await MainWebView.EvaluateJavaScriptAsync("document.title");
        StatusLabel.Text = $"JS Result: {result ?? "(null)"}";
    }
    catch (Exception ex)
    {
        StatusLabel.Text = $"JS Error: {ex.Message}";
    }
}
```

**Code Example - Loading HTML:**

```csharp
private void OnLoadHtmlClicked(object? sender, EventArgs e)
{
    var html = @"
<!DOCTYPE html>
<html>
<head>
    <style>
        body { font-family: Arial; margin: 40px; }
        button { padding: 15px 30px; font-size: 1.1em; }
    </style>
</head>
<body>
    <h1>Hello from OpenMaui!</h1>
    <button onclick=""alert('Hello from JavaScript!')"">Click Me!</button>
</body>
</html>";

    MainWebView.Source = new HtmlWebViewSource { Html = html };
}
```

**Logging:**
Application logs are written to `~/webviewdemo.log` for debugging.

## Project Structure

Each sample follows a similar structure:

```
SampleApp/
├── Program.cs              # Linux platform entry point
├── MauiProgram.cs          # MAUI app configuration
├── App.xaml                # Application resources and theme definitions
├── App.xaml.cs             # Application lifecycle
├── SampleApp.csproj        # Project configuration
├── Pages/                  # XAML pages and code-behind
│   ├── MainPage.xaml
│   └── MainPage.xaml.cs
├── Resources/              # Images, fonts, icons
│   ├── AppIcon/
│   └── Images/
└── run.sh                  # Launcher script
```

### Project Configuration

All samples use conditional compilation for cross-platform support:

```xml
<!-- SampleApp.csproj -->
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <TargetFramework>net10.0</TargetFramework>
    <OutputType>Exe</OutputType>
    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
  </PropertyGroup>

  <!-- Linux: Use OpenMaui -->
  <PropertyGroup Condition="$([MSBuild]::IsOSPlatform('Linux'))">
    <RuntimeIdentifiers>linux-x64;linux-arm64</RuntimeIdentifiers>
  </PropertyGroup>

  <!-- Local development -->
  <ItemGroup Condition="$([MSBuild]::IsOSPlatform('Linux')) AND Exists('../../maui-linux/OpenMaui.Controls.Linux.csproj')">
    <ProjectReference Include="../../maui-linux/OpenMaui.Controls.Linux.csproj" />
  </ItemGroup>

  <!-- CI/CD or standalone -->
  <ItemGroup Condition="$([MSBuild]::IsOSPlatform('Linux')) AND !Exists('../../maui-linux/OpenMaui.Controls.Linux.csproj')">
    <PackageReference Include="OpenMaui.Controls.Linux" Version="*" />
  </ItemGroup>
</Project>
```

## Development Guide

### Creating a New Linux MAUI App

1. **Create project structure:**

```bash
mkdir MyApp
cd MyApp
dotnet new console -n MyApp
```

2. **Edit MyApp.csproj:**

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
    <EnableDefaultXamlItems>true</EnableDefaultXamlItems>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="OpenMaui.Controls.Linux" Version="*" />
  </ItemGroup>
</Project>
```

3. **Create Program.cs:**

```csharp
using Microsoft.Maui.Platform.Linux;

namespace MyApp;

class Program
{
    static void Main(string[] args)
    {
        var app = MauiProgram.CreateMauiApp();
        LinuxApplication.Run(app, args);
    }
}
```

4. **Create MauiProgram.cs:**

```csharp
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Platform.Linux.Hosting;

namespace MyApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>();
        builder.UseLinux();
        return builder.Build();
    }
}
```

5. **Create App.xaml and App.xaml.cs** (see samples for examples)

6. **Build and run:**

```bash
dotnet build
dotnet run
```

### Exception Handling

All samples include comprehensive exception handling:

```csharp
// Global exception handlers in Program.cs
AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
{
    var ex = e.ExceptionObject as Exception;
    Console.WriteLine($"[FATAL] Unhandled exception: {ex?.Message}");
    Console.WriteLine($"[FATAL] Stack trace: {ex?.StackTrace}");
};

TaskScheduler.UnobservedTaskException += (sender, e) =>
{
    Console.WriteLine($"[FATAL] Unobserved task exception: {e.Exception?.Message}");
    e.SetObserved(); // Prevent crash
};
```

### Logging

All samples redirect console output to log files in the user's home directory:

```csharp
var logPath = Path.Combine(
    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), 
    "myapp.log");
using var logWriter = new StreamWriter(logPath, append: false) { AutoFlush = true };
var multiWriter = new MultiTextWriter(Console.Out, logWriter);
Console.SetOut(multiWriter);
Console.SetError(multiWriter);
```

## API Usage Examples

### Navigation

**NavigationPage (TodoApp):**

```csharp
// App.xaml.cs - Create NavigationPage
protected override Window CreateWindow(IActivationState? activationState)
{
    NavigationPage = new NavigationPage(new TodoListPage())
    {
        BarBackgroundColor = Color.FromArgb("#5C6BC0"),
        BarTextColor = Colors.White
    };
    return new Window(NavigationPage);
}

// Push a page
await Navigation.PushAsync(new TodoDetailPage(todo));

// Pop back
await Navigation.PopAsync();
```

**Shell Navigation (ShellDemo):**

```csharp
// AppShell.xaml.cs - Register routes
Routing.RegisterRoute("detail", typeof(DetailPage));

// Navigate using route
await Shell.Current.GoToAsync("detail?item=MyItem");

// Navigate with parameters
await Shell.Current.GoToAsync($"detail?item={Uri.EscapeDataString(itemName)}");

// Use LinuxViewRenderer for direct navigation
LinuxViewRenderer.NavigateToRoute("Buttons");
LinuxViewRenderer.PushPage(new DetailPage());
LinuxViewRenderer.PopPage();
```

### Data Binding

**Observable Collections:**

```csharp
public class TodoService
{
    public ObservableCollection<TodoItem> Todos { get; } = new();
    
    public TodoItem AddTodo(string title, string notes = "")
    {
        var todo = new TodoItem { Title = title, Notes = notes };
        Todos.Add(todo);
        return todo;
    }
}
```

**INotifyPropertyChanged:**

```csharp
public class TodoItem : INotifyPropertyChanged
{
    private bool _isCompleted;
    
    public bool IsCompleted
    {
        get => _isCompleted;
        set
        {
            if (_isCompleted != value)
            {
                _isCompleted = value;
                OnPropertyChanged(nameof(IsCompleted));
            }
        }
    }
    
    public event PropertyChangedEventHandler? PropertyChanged;
    
    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
```

### Value Converters

**Theme-Aware Color Converter:**

```csharp
public class CompletedToColorConverter : IValueConverter
{
    private static readonly Color AccentColorLight = Color.FromArgb("#26A69A");
    private static readonly Color AccentColorDark = Color.FromArgb("#4DB6AC");
    
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        bool isCompleted = value is bool b && b;
        bool isDarkMode = Application.Current?.RequestedTheme == AppTheme.Dark;
        
        if (isCompleted)
            return Color.FromArgb("#9E9E9E");
        
        return isDarkMode ? AccentColorDark : AccentColorLight;
    }
    
    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
```

**Register in App.xaml:**

```xaml
<Application.Resources>
    <local:CompletedToColorConverter x:Key="CompletedToColorConverter"/>
</Application.Resources>
```

### Theme Switching

**Toggle Theme:**

```csharp
private void OnThemeToggleClicked(object? sender, EventArgs e)
{
    if (Application.Current == null) return;
    
    var isDarkMode = Application.Current.UserAppTheme == AppTheme.Dark;
    Application.Current.UserAppTheme = isDarkMode ? AppTheme.Light : AppTheme.Dark;
}
```

**AppThemeBinding in XAML:**

```xaml
<Border BackgroundColor="{AppThemeBinding Light=#FFFFFF, Dark=#1E1E1E}">
    <Label TextColor="{AppThemeBinding Light=#212121, Dark=#FFFFFF}" 
           Text="Theme-aware text"/>
</Border>
```

**Programmatic AppThemeBinding:**

```csharp
label.SetAppThemeColor(Label.TextColorProperty,
    Colors.Black,  // Light theme
    Colors.White); // Dark theme
```

### Dialogs

**DisplayAlert (using LinuxDialogService):**

```csharp
private async void OnDeleteClicked(object? sender, EventArgs e)
{
    var confirmed = await LinuxDialogService.ShowAlertAsync(
        "Delete Task",
        $"Are you sure you want to delete \"{_todo.Title}\"?",
        "Delete",
        "Cancel");
    
    if (confirmed)
    {
        _service.DeleteTodo(_todo);
        await Navigation.PopAsync();
    }
}
```

### WebView

**Load URL:**

```csharp
MainWebView.Source = new UrlWebViewSource { Url = "https://dotnet.microsoft.com" };
```

**Load HTML:**

```csharp
MainWebView.Source = new HtmlWebViewSource 
{ 
    Html = "<html><body><h1>Hello!</h1></body></html>" 
};
```

**Execute JavaScript:**

```csharp
var result = await MainWebView.EvaluateJavaScriptAsync("document.title");
```

**Navigation Events:**

```csharp
private void OnNavigating(object? sender, WebNavigatingEventArgs e)
{
    Console.WriteLine($"Navigating to: {e.Url}");
    // e.Cancel = true; // Cancel navigation if needed
}

private void OnNavigated(object? sender, WebNavigatedEventArgs e)
{
    Console.WriteLine($"Navigated: {e.Result} - {e.Url}");
}
```

## Related Resources

- **[OpenMaui Linux Framework](https://git.marketally.com/open-maui/maui-linux)** - The core framework repository
- **[NuGet Package](https://www.nuget.org/packages/OpenMaui.Controls.Linux)** - Install via NuGet
- **[.NET MAUI Documentation](https://learn.microsoft.com/dotnet/maui/)** - Official Microsoft documentation
- **[SkiaSharp Documentation](https://learn.microsoft.com/xamarin/xamarin-forms/user-interface/graphics/skiasharp/)** - Graphics rendering engine

## Support

If you find OpenMaui useful, consider supporting the developer:

<a href="https://buymeacoffee.com/logikonline" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/v2/default-yellow.png" alt="Buy Me A Coffee" height="40"></a>

## License

MIT License - See [LICENSE](LICENSE) for details.

Copyright (c) 2024-2026 OpenMaui

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.