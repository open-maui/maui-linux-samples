
# OpenMaui Linux Samples - User Guide

A collection of sample applications demonstrating .NET MAUI applications running on Linux using the OpenMaui Linux platform. These samples showcase various MAUI controls, navigation patterns, and features working with SkiaSharp-based rendering on Linux desktop.

## Table of Contents

- [Overview](#overview)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
  - [Building the Samples](#building-the-samples)
  - [Running the Applications](#running-the-applications)
- [Sample Applications](#sample-applications)
  - [ShellDemo](#shelldemo)
  - [TodoApp](#todoapp)
  - [WebViewDemo](#webviewdemo)
- [Common Workflows](#common-workflows)
  - [Creating a New Linux MAUI App](#creating-a-new-linux-maui-app)
  - [Adding OpenMaui Linux Support](#adding-openmaui-linux-support)
  - [Implementing Navigation](#implementing-navigation)
  - [Working with Themes](#working-with-themes)
- [Project Structure](#project-structure)
- [API Reference](#api-reference)
  - [MauiProgram Configuration](#mauiprogram-configuration)
  - [Platform Entry Point](#platform-entry-point)
  - [Navigation APIs](#navigation-apis)
  - [Dialog Services](#dialog-services)
- [Tips and Best Practices](#tips-and-best-practices)
- [Troubleshooting](#troubleshooting)

## Overview

This repository contains three production-ready sample applications that demonstrate different aspects of building .NET MAUI applications for Linux:

- **ShellDemo**: Comprehensive showcase of MAUI controls (buttons, text input, lists, pickers, grids) with Shell-based navigation
- **TodoApp**: Full-featured task management app demonstrating NavigationPage, MVVM patterns, and data binding
- **WebViewDemo**: Web browser application showcasing WebKitGTK integration with HTML rendering and JavaScript execution

All samples are built on the OpenMaui.Controls.Linux platform, which brings .NET MAUI to Linux desktop using SkiaSharp for rendering.

## Getting Started

### Prerequisites

Before you begin, ensure you have the following installed on your Linux system:

- **.NET 9.0 SDK** or later
- **OpenMaui.Controls.Linux** package or source
- **GTK 3** (for WebView support)
- **WebKitGTK** (for WebViewDemo)

Install system dependencies on Ubuntu/Debian:

```bash
sudo apt-get update
sudo apt-get install dotnet-sdk-9.0 libgtk-3-dev libwebkit2gtk-4.0-dev
```

### Installation

Clone the repository:

```bash
git clone https://github.com/openmaui/maui-linux-samples.git
cd maui-linux-samples
```

The samples support two development modes:

**Local Development** (with OpenMaui source):
```bash
# Clone OpenMaui alongside the samples
cd ..
git clone https://github.com/openmaui/maui-linux.git
cd maui-linux-samples
```

**Package Reference** (using NuGet):
```bash
# Set environment variable to use package reference
export UsePackageReference=true
```

### Building the Samples

Build all samples in the solution:

```bash
dotnet build maui-linux-samples.sln
```

Build a specific sample:

```bash
cd ShellDemo
dotnet build
```

Build for release:

```bash
dotnet build -c Release
```

### Running the Applications

Each sample includes a `run.sh` script for easy execution:

```bash
cd ShellDemo
./run.sh
```

Or run directly with `dotnet`:

```bash
cd ShellDemo
dotnet run
```

Run from the compiled output:

```bash
cd ShellDemo/bin/Debug/net9.0
./ShellDemo
```

## Sample Applications

### ShellDemo

A comprehensive demonstration of MAUI controls and Shell navigation patterns.

**Features:**
- Shell-based navigation with flyout menu
- Button controls with various styles and events
- Text input controls (Entry, Editor, SearchBar)
- Selection controls (CheckBox, Switch, Slider)
- Pickers (Picker, DatePicker, TimePicker)
- CollectionView with selection and data binding
- Progress indicators (ProgressBar, ActivityIndicator)
- Grid layouts with various sizing options
- Theme switching (Light/Dark mode)
- Push/pop navigation for detail pages

**Key Files:**
- `AppShell.xaml` - Shell configuration with flyout menu
- `Pages/HomePage.xaml` - Welcome page with feature cards
- `Pages/ButtonsPage.xaml` - Button demonstrations
- `Pages/ListsPage.xaml` - CollectionView examples
- `Pages/GridsPage.xaml` - Grid layout demonstrations

**Running ShellDemo:**

```bash
cd ShellDemo
./run.sh
```

**Example: Navigating to a detail page**

```csharp
// From any page in ShellDemo
private void OnPushDetailClicked(object? sender, EventArgs e)
{
    var success = LinuxViewRenderer.PushPage(new DetailPage("My Item"));
    Console.WriteLine($"Navigation result: {success}");
}
```

**Log File Location:**

ShellDemo writes diagnostic logs to `~/shelldemo.log` for debugging.

### TodoApp

A full-featured task management application demonstrating real-world MAUI patterns.

**Features:**
- NavigationPage-based navigation
- CRUD operations (Create, Read, Update, Delete)
- Data binding with INotifyPropertyChanged
- ObservableCollection for reactive lists
- Custom value converters for UI logic
- Alternating row colors in lists
- Task completion tracking with statistics
- Confirmation dialogs for destructive actions
- Theme support with dynamic color updates

**Key Files:**
- `App.xaml.cs` - NavigationPage setup
- `TodoItem.cs` - Data model with property change notifications
- `TodoService.cs` - Business logic and data management
- `Pages/TodoListPage.xaml` - Main list view with statistics
- `Pages/TodoDetailPage.xaml` - Task editing and deletion
- `Pages/NewTodoPage.xaml` - Task creation form

**Running TodoApp:**

```bash
cd TodoApp
./run.sh
```

**Example: Adding a new task**

```csharp
// In NewTodoPage.xaml.cs
private async void OnSaveClicked(object? sender, EventArgs e)
{
    var title = TitleEntry.Text?.Trim();
    
    if (string.IsNullOrEmpty(title))
    {
        TitleEntry.Placeholder = "Title is required!";
        TitleEntry.PlaceholderColor = Colors.Red;
        return;
    }
    
    TodoService.Instance.AddTodo(title, NotesEditor.Text ?? "");
    await Navigation.PopAsync();
}
```

**Example: Custom value converter**

```csharp
// Converter for alternating row colors with theme support
public class AlternatingRowColorConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        bool isDarkMode = Application.Current?.RequestedTheme == AppTheme.Dark;
        
        if (value is int index)
        {
            if (isDarkMode)
                return index % 2 == 0 ? Color.FromArgb("#1E1E1E") : Color.FromArgb("#2A2A2A");
            return index % 2 == 0 ? Colors.White : Color.FromArgb("#F5F5F5");
        }
        return isDarkMode ? Color.FromArgb("#1E1E1E") : Colors.White;
    }
    
    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
```

**Log File Location:**

TodoApp writes diagnostic logs to `~/todoapp.log`.

### WebViewDemo

A web browser application showcasing WebKitGTK integration with MAUI.

**Features:**
- WebView with WebKitGTK backend
- URL navigation with address bar
- Back/forward navigation history
- Page reload functionality
- HTML content loading (local and remote)
- JavaScript execution and evaluation
- Progress indication during page loads
- Theme switching
- Double-click to select all in URL entry

**Key Files:**
- `Pages/WebViewPage.xaml` - Main browser interface
- `Program.cs` - GTK mode initialization for WebView

**Running WebViewDemo:**

```bash
cd WebViewDemo
./run.sh
```

**Example: Loading a URL**

```csharp
private void Navigate()
{
    var url = UrlEntry.Text?.Trim();
    if (string.IsNullOrEmpty(url))
        return;
    
    // Add https:// if not present
    if (!url.StartsWith("http://") && !url.StartsWith("https://"))
        url = "https://" + url;
    
    MainWebView.Source = new UrlWebViewSource { Url = url };
    UrlEntry.Text = url;
}
```

**Example: Loading HTML content**

```csharp
private void OnLoadHtmlClicked(object? sender, EventArgs e)
{
    var html = @"
<!DOCTYPE html>
<html>
<head>
    <title>OpenMaui WebView</title>
    <style>
        body { font-family: Arial; margin: 40px; }
        h1 { color: #667eea; }
    </style>
</head>
<body>
    <h1>Hello from OpenMaui Linux!</h1>
    <p>This HTML is rendered by WebKitGTK.</p>
</body>
</html>";
    
    MainWebView.Source = new HtmlWebViewSource { Html = html };
}
```

**Example: Evaluating JavaScript**

```csharp
private async void OnEvalJsClicked(object? sender, EventArgs e)
{
    try
    {
        var result = await MainWebView.EvaluateJavaScriptAsync("document.title");
        StatusLabel.Text = $"Page title: {result}";
    }
    catch (Exception ex)
    {
        StatusLabel.Text = $"Error: {ex.Message}";
    }
}
```

**GTK Mode Requirement:**

WebViewDemo requires GTK mode to be enabled in `Program.cs`:

```csharp
LinuxApplication.Run(app, args, options =>
{
    options.UseGtk = true;
});
```

**Log File Location:**

WebViewDemo writes diagnostic logs to `~/webviewdemo.log`.

## Common Workflows

### Creating a New Linux MAUI App

Create a new .NET MAUI application that runs on Linux:

**Step 1: Create project structure**

```bash
mkdir MyLinuxApp
cd MyLinuxApp
dotnet new console -n MyLinuxApp
```

**Step 2: Update the .csproj file**

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net9.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
    
    <ApplicationTitle>My Linux App</ApplicationTitle>
    <ApplicationId>com.mycompany.mylinuxapp</ApplicationId>
    <ApplicationVersion>1.0.0</ApplicationVersion>
    
    <SingleProject>true</SingleProject>
    <EnableDefaultXamlItems>true</EnableDefaultXamlItems>
  </PropertyGroup>
  
  <PropertyGroup Condition="$([MSBuild]::IsOSPlatform('Linux'))">
    <RuntimeIdentifiers>linux-x64;linux-arm64</RuntimeIdentifiers>
  </PropertyGroup>
  
  <ItemGroup Condition="$([MSBuild]::IsOSPlatform('Linux'))">
    <PackageReference Include="OpenMaui.Controls.Linux" Version="*" />
  </ItemGroup>
</Project>
```

**Step 3: Create Program.cs**

```csharp
using Microsoft.Maui.Platform.Linux;

namespace MyLinuxApp;

class Program
{
    static void Main(string[] args)
    {
        var logPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), 
            "mylinuxapp.log");
        using var logWriter = new StreamWriter(logPath, append: false) { AutoFlush = true };
        var multiWriter = new MultiTextWriter(Console.Out, logWriter);
        Console.SetOut(multiWriter);
        
        Console.WriteLine($"Starting MyLinuxApp at {DateTime.Now}");
        
        var app = MauiProgram.CreateMauiApp();
        LinuxApplication.Run(app, args);
    }
}

class MultiTextWriter : TextWriter
{
    private readonly TextWriter[] _writers;
    public MultiTextWriter(params TextWriter[] writers) => _writers = writers;
    public override System.Text.Encoding Encoding => System.Text.Encoding.UTF8;
    public override void Write(char value) { foreach (var w in _writers) w.Write(value); }
    public override void WriteLine(string? value) { foreach (var w in _writers) w.WriteLine(value); }
}
```

**Step 4: Create MauiProgram.cs**

```csharp
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Platform.Linux.Hosting;

namespace MyLinuxApp;

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

**Step 5: Create App.xaml and App.xaml.cs**

```xml
<!-- App.xaml -->
<?xml version="1.0" encoding="utf-8" ?>
<Application xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="MyLinuxApp.App">
    <Application.Resources>
        <ResourceDictionary>
            <!-- Add your resources here -->
        </ResourceDictionary>
    </Application.Resources>
</Application>
```

```csharp
// App.xaml.cs
using Microsoft.Maui.Controls;

namespace MyLinuxApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }
    
    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new MainPage());
    }
}
```

**Step 6: Build and run**

```bash
dotnet build
dotnet run
```

### Adding OpenMaui Linux Support

Add Linux support to an existing MAUI project:

**Step 1: Update .csproj conditionally**

```xml
<!-- Linux-specific configuration -->
<PropertyGroup Condition="$([MSBuild]::IsOSPlatform('Linux'))">
  <RuntimeIdentifiers>linux-x64;linux-arm64</RuntimeIdentifiers>
</PropertyGroup>

<!-- Add OpenMaui package for Linux -->
<ItemGroup Condition="$([MSBuild]::IsOSPlatform('Linux'))">
  <PackageReference Include="OpenMaui.Controls.Linux" Version="*" />
</ItemGroup>
```

**Step 2: Update MauiProgram.cs**

```csharp
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Platform.Linux.Hosting;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>();
        
        // Add Linux platform support
        builder.UseLinux();
        
        return builder.Build();
    }
}
```

**Step 3: Create Linux entry point (Program.cs)**

```csharp
using Microsoft.Maui.Platform.Linux;

namespace YourApp;

class Program
{
    static void Main(string[] args)
    {
        var app = MauiProgram.CreateMauiApp();
        LinuxApplication.Run(app, args);
    }
}
```

### Implementing Navigation

OpenMaui Linux supports multiple navigation patterns:

**Shell Navigation (ShellDemo pattern)**

```csharp
// AppShell.xaml
<?xml version="1.0" encoding="UTF-8" ?>
<Shell xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
       xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
       xmlns:local="clr-namespace:MyApp"
       x:Class="MyApp.AppShell">
    
    <FlyoutItem Title="Home">
        <ShellContent ContentTemplate="{DataTemplate local:HomePage}" />
    </FlyoutItem>
    
    <FlyoutItem Title="Settings">
        <ShellContent ContentTemplate="{DataTemplate local:SettingsPage}" />
    </FlyoutItem>
</Shell>
```

```csharp
// AppShell.xaml.cs
public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        
        // Register routes for push navigation
        Routing.RegisterRoute("details", typeof(DetailsPage));
    }
}

// Navigate using routes
await Shell.Current.GoToAsync("details?id=123");
```

**NavigationPage Pattern (TodoApp pattern)**

```csharp
// App.xaml.cs
protected override Window CreateWindow(IActivationState? activationState)
{
    var navigationPage = new NavigationPage(new MainPage())
    {
        BarBackgroundColor = Color.FromArgb("#5C6BC0"),
        BarTextColor = Colors.White
    };
    
    return new Window(navigationPage);
}

// Push a new page
await Navigation.PushAsync(new DetailsPage());

// Pop back
await Navigation.PopAsync();
```

**Direct Push/Pop with LinuxViewRenderer**

```csharp
// Push a page directly
var success = LinuxViewRenderer.PushPage(new DetailPage());

// Pop the current page
var success = LinuxViewRenderer.PopPage();

// Navigate to a Shell route
LinuxViewRenderer.NavigateToRoute("settings");
```

### Working with Themes

All samples support Light and Dark themes with dynamic switching.

**Step 1: Define theme resources in App.xaml**

```xml
<Application.Resources>
    <ResourceDictionary>
        <!-- Light theme colors -->
        <Color x:Key="PrimaryLight">#5C6BC0</Color>
        <Color x:Key="BackgroundLight">#FFFFFF</Color>
        <Color x:Key="TextPrimaryLight">#212121</Color>
        
        <!-- Dark theme colors -->
        <Color x:Key="PrimaryDark">#3949AB</Color>
        <Color x:Key="BackgroundDark">#121212</Color>
        <Color x:Key="TextPrimaryDark">#FFFFFF</Color>
    </ResourceDictionary>
</Application.Resources>
```

**Step 2: Use AppThemeBinding in XAML**

```xml
<Label Text="Hello World">
    <Label.TextColor>
        <AppThemeBinding Light="{StaticResource TextPrimaryLight}"
                        Dark="{StaticResource TextPrimaryDark}" />
    </Label.TextColor>
</Label>
```

**Step 3: Use SetAppThemeColor in code**

```csharp
var label = new Label { Text = "Hello World" };
label.SetAppThemeColor(
    Label.TextColorProperty,
    Color.FromArgb("#212121"),  // Light
    Color.FromArgb("#FFFFFF")   // Dark
);
```

**Step 4: Toggle theme programmatically**

```csharp
private void OnThemeToggleClicked(object? sender, EventArgs e)
{
    if (Application.Current == null) return;
    
    var currentTheme = Application.Current.UserAppTheme;
    var newTheme = currentTheme == AppTheme.Dark ? AppTheme.Light : AppTheme.Dark;
    
    Application.Current.UserAppTheme = newTheme;
}
```

**Step 5: Respond to theme changes**

```csharp
protected override void OnAppearing()
{
    base.OnAppearing();
    UpdateThemeUI();
}

private void UpdateThemeUI()
{
    var isDark = Application.Current?.UserAppTheme == AppTheme.Dark ||
                 (Application.Current?.UserAppTheme == AppTheme.Unspecified &&
                  Application.Current?.RequestedTheme == AppTheme.Dark);
    
    ThemeIcon.Source = isDark ? "light_mode.svg" : "dark_mode.svg";
}
```

## Project Structure

All sample projects follow a consistent structure:

```
SampleApp/
├── Program.cs                 # Linux platform entry point
├── MauiProgram.cs            # MAUI app configuration
├── App.xaml                  # Application resources and theme
├── App.xaml.cs               # Application code-behind
├── AppShell.xaml             # Shell navigation (ShellDemo only)
├── Pages/                    # Application pages
│   ├── HomePage.xaml
│   ├── HomePage.xaml.cs
│   └── ...
├── Resources/                # Images, icons, fonts
│   ├── AppIcon/
│   └── Images/
├── run.sh                    # Launch script
└── SampleApp.csproj          # Project file
```

**Key Components:**

| File | Purpose |
|------|---------|
| `Program.cs` | Platform entry point, sets up logging and exception handling |
| `MauiProgram.cs` | Configures MAUI app with `UseLinux()` extension |
| `App.xaml` | Application-level resources, themes, and styles |
| `AppShell.xaml` | Shell navigation structure (flyout, tabs, routes) |
| `*.csproj` | Project configuration with conditional Linux support |
| `run.sh` | Convenience script for launching the app |

## API Reference

### MauiProgram Configuration

Configure your MAUI app for Linux in `MauiProgram.cs`:

```csharp
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Platform.Linux.Hosting;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        
        // Register your app
        builder.UseMauiApp<App>();
        
        // Add Linux platform support (registers all handlers)
        builder.UseLinux();
        
        // Configure fonts (optional)
        builder.ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        });
        
        return builder.Build();
    }
}
```

### Platform Entry Point

Create a Linux entry point in `Program.cs`:

```csharp
using Microsoft.Maui.Platform.Linux;

class Program
{
    static void Main(string[] args)
    {
        // Optional: Set up logging
        var logPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
            "myapp.log");
        using var logWriter = new StreamWriter(logPath, append: false) { AutoFlush = true };
        var multiWriter = new MultiTextWriter(Console.Out, logWriter);
        Console.SetOut(multiWriter);
        Console.SetError(multiWriter);
        
        // Optional: Global exception handlers
        AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
        {
            var ex = e.ExceptionObject as Exception;
            Console.WriteLine($"[FATAL] Unhandled exception: {ex?.Message}");
        };
        
        try
        {
            var app = MauiProgram.CreateMauiApp();
            
            // Run with default options
            LinuxApplication.Run(app, args);
            
            // Or run with GTK mode (required for WebView)
            // LinuxApplication.Run(app, args, options =>
            // {
            //     options.UseGtk = true;
            // });
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[FATAL] Exception in Main: {ex.Message}");
            throw;
        }
    }
}
```

### Navigation APIs

Navigate between pages using these APIs:

**LinuxViewRenderer.PushPage**

```csharp
// Push a new page onto the navigation stack
bool success = LinuxViewRenderer.PushPage(new DetailPage());
```

**LinuxViewRenderer.PopPage**

```csharp
// Pop the current page from the navigation stack
bool success = LinuxViewRenderer.PopPage();
```

**LinuxViewRenderer.NavigateToRoute**

```csharp
// Navigate to a registered Shell route
LinuxViewRenderer.NavigateToRoute("settings");
```

**Navigation Property (in NavigationPage)**

```csharp
// Push a page
await Navigation.PushAsync(new DetailPage());

// Pop a page
await Navigation.PopAsync();

// Pop to root
await Navigation.PopToRootAsync();
```

**Shell Navigation**

```csharp
// Navigate to a route
await Shell.Current.GoToAsync("details");

// Navigate with parameters
await Shell.Current.GoToAsync($"details?id={itemId}");

// Navigate back
await Shell.Current.GoToAsync("..");
```

### Dialog Services

Show alerts and confirmation dialogs:

**LinuxDialogService.ShowAlertAsync**

```csharp
// Show confirmation dialog
bool confirmed = await LinuxDialogService.ShowAlertAsync(
    "Delete Task",
    "Are you sure you want to delete this task?",
    "Delete",
    "Cancel");

if (confirmed)
{
    // User clicked "Delete"
    DeleteTask();
}
```

**DisplayAlert (MAUI standard)**

```csharp
// Show alert with OK button
await DisplayAlert("Success", "Task saved successfully", "OK");

// Show confirmation dialog
bool answer = await DisplayAlert(
    "Confirm",
    "Delete this item?",
    "Yes",
    "No");
```

## Tips and Best Practices

### Performance

1. **Use compiled bindings** for better performance:
   ```xml
   <Label Text="{Binding Title, Mode=OneWay}" />
   ```

2. **Virtualize lists** with CollectionView (default behavior):
   ```xml
   <CollectionView ItemsSource="{Binding Items}" />
   ```

3. **Avoid excessive property change notifications**:
   ```csharp
   private string _title;
   public string Title
   {
       get => _title;
       set
       {
           if (_title != value)  // Only notify if changed
           {
               _title = value;
               OnPropertyChanged(nameof(Title));
           }
       }
   }
   ```

### Logging and Debugging

1. **All samples write logs** to `~/appname.log`:
   ```bash
   tail -f ~/shelldemo.log
   ```

2. **Add console logging** throughout your app:
   ```csharp
   Console.WriteLine($"[MyPage] Button clicked at {DateTime.Now}");
   ```

3. **Use global exception handlers** (see `Program.cs` examples)

### Theme Support

1. **Always use AppThemeBinding** for colors that should change with theme:
   ```xml
   <Label.TextColor>
       <AppThemeBinding Light="#212121" Dark="#FFFFFF" />
   </Label.TextColor>
   ```

2. **Test both themes** during development:
   ```csharp
   Application.Current.UserAppTheme = AppTheme.Dark;  // Test dark mode
   ```

3. **Update UI when theme changes**:
   ```csharp
   Application.Current.RequestedThemeChanged += (s, e) =>
   {
       UpdateThemeSpecificUI();
   };
   ```

### Resource Management

1. **Use embedded resources** for images:
   ```xml
   <ItemGroup>
       <EmbeddedResource Include="Resources/Images/*.svg" />
   </ItemGroup>
   ```

2. **Reference images** in XAML:
   ```xml
   <Image Source="logo.svg" />
   ```

### Navigation Patterns

1. **Use Shell for complex navigation** (flyout, tabs, routes)
2. **Use NavigationPage for simple hierarchical navigation**
3. **Register routes** for type-safe navigation:
   ```csharp
   Routing.RegisterRoute("details", typeof(DetailsPage));
   ```

### Data Binding

1. **Implement INotifyPropertyChanged** for reactive data:
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

2. **Use ObservableCollection** for lists:
   ```csharp
   public ObservableCollection<TodoItem> Todos { get; } = new();
   ```

## Troubleshooting

### Application won't start

**Problem:** App crashes immediately on launch

**Solutions:**

1. Check the log file (`~/appname.log`):
   ```bash
   cat ~/shelldemo.log
   ```

2. Verify .NET SDK is installed:
   ```bash
   dotnet --version
   ```

3. Ensure OpenMaui package is referenced:
   ```bash
   dotnet restore
   dotnet build
   ```

4. Check for missing dependencies:
   ```bash
   ldd bin/Debug/net9.0/ShellDemo
   ```

### WebView not working

**Problem:** WebView shows blank or crashes

**Solutions:**

1. Verify WebKitGTK is installed:
   ```bash
   sudo apt-get install libwebkit2gtk-4.0-dev
   ```

2. Ensure GTK mode is enabled in `Program.cs`:
   ```csharp
   LinuxApplication.Run(app, args, options =>
   {
       options.UseGtk = true;
   });
   ```

3. Check WebView logs:
   ```bash
   cat ~/webviewdemo.log | grep WebView
   ```

### Navigation not working

**Problem:** PushPage or PopPage returns false

**Solutions:**

1. Ensure you're in a NavigationPage or Shell context:
   ```csharp
   // Check if navigation is available
   if (Navigation != null)
   {
       await Navigation.PushAsync(new DetailPage());
   }
   ```

2. For Shell navigation, register routes:
   ```csharp
   Routing.RegisterRoute("details", typeof(DetailsPage));
   ```

3. Check console output for navigation errors:
   ```bash
   grep "Navigation" ~/shelldemo.log
   ```

### Theme not updating

**Problem:** UI doesn't update when theme changes

**Solutions:**

1. Use `AppThemeBinding` instead of static colors:
   ```xml
   <!-- Wrong -->
   <Label TextColor="#212121" />
   
   <!-- Correct -->
   <Label>
       <Label.TextColor>
           <AppThemeBinding Light="#212121" Dark="#FFFFFF" />
       </Label.TextColor>
   </Label>
   ```

2. Subscribe to theme change events:
   ```csharp
   Application.Current.RequestedThemeChanged += (s, e) =>
   {
       UpdateUI();
   };
   ```

3. Force UI refresh in `OnAppearing`:
   ```csharp
   protected override void OnAppearing()
   {
       base.OnAppearing();
       UpdateThemeUI();
   }
   ```

### Build errors on Linux

**Problem:** Build fails with missing references

**Solutions:**

1. Restore packages:
   ```bash
   dotnet restore
   ```

2. Clean and rebuild:
   ```bash
   dotnet clean
   dotnet build
   ```

3. Check .csproj conditional compilation:
   ```xml
   <ItemGroup Condition="$([MSBuild]::IsOSPlatform('Linux'))">
       <PackageReference Include="OpenMaui.Controls.Linux" Version="*" />
   </ItemGroup>
   ```

4. Verify you're on Linux:
   ```bash
   uname -a
   ```

### Images not displaying

**Problem:** Images show as blank or missing

**Solutions:**

1. Check image paths are correct:
   ```xml
   <Image Source="logo.svg" />  <!-- Looks in Resources/Images/ -->
   ```

2. Verify images are included in .csproj:
   ```xml
   <ItemGroup>
       <EmbeddedResource Include="Resources/Images/*.svg" />
   </ItemGroup>
   ```

3. Use absolute paths for testing:
   ```csharp
   Image.Source = ImageSource.FromFile("/full/path/to/image.png");
   ```

### Performance issues

**Problem:** App is slow or unresponsive

**Solutions:**

1. Use virtualization for long lists (CollectionView does this by default)

2. Avoid binding to expensive properties:
   ```csharp
   // Bad: Computed property called on every frame
   public string ExpensiveProperty => ComputeExpensiveValue();
   
   // Good: Cache the value
   private string _cachedValue;
   public string CachedProperty => _cachedValue ??= ComputeExpensiveValue();
   ```

3. Profile with console timestamps:
   ```csharp
   var sw = System.Diagnostics.Stopwatch.StartNew();
   // ... operation ...
   Console.WriteLine($"Operation took {sw.ElapsedMilliseconds}ms");
   ```

---

For more information, visit the [OpenMaui GitHub repository](https://github.com/openmaui) or check the individual sample README files.
