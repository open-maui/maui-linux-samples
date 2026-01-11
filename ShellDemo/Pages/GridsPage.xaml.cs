// GridsPage - Demonstrates Grid layouts with various options

using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace ShellDemo;

public partial class GridsPage : ContentPage
{
    public GridsPage()
    {
        InitializeComponent();
        BuildContent();
    }

    private void BuildContent()
    {
        MainContent.Children.Add(CreateSectionHeader("Basic Grid (2x2)"));
        MainContent.Children.Add(CreateBasicGrid());

        MainContent.Children.Add(CreateSectionHeader("Column Definitions"));
        MainContent.Children.Add(CreateColumnDefinitionsDemo());

        MainContent.Children.Add(CreateSectionHeader("Row Definitions"));
        MainContent.Children.Add(CreateRowDefinitionsDemo());

        MainContent.Children.Add(CreateSectionHeader("Star Sizing (Proportional)"));
        MainContent.Children.Add(CreateStarSizingDemo());

        MainContent.Children.Add(CreateSectionHeader("Row & Column Spacing"));
        MainContent.Children.Add(CreateSpacingDemo());

        MainContent.Children.Add(CreateSectionHeader("Row & Column Span"));
        MainContent.Children.Add(CreateSpanDemo());

        MainContent.Children.Add(CreateSectionHeader("Mixed Sizing"));
        MainContent.Children.Add(CreateMixedSizingDemo());

        MainContent.Children.Add(new BoxView { HeightRequest = 20 });
    }

    private Label CreateSectionHeader(string text)
    {
        var label = new Label
        {
            Text = text,
            FontSize = 18,
            FontAttributes = FontAttributes.Bold,
            Margin = new Thickness(0, 10, 0, 5)
        };
        label.SetAppThemeColor(Label.TextColorProperty,
            Color.FromArgb("#2196F3"),
            Color.FromArgb("#64B5F6"));
        return label;
    }

    private View CreateBasicGrid()
    {
        var grid = new Grid
        {
            RowDefinitions =
            {
                new RowDefinition { Height = GridLength.Auto },
                new RowDefinition { Height = GridLength.Auto }
            },
            ColumnDefinitions =
            {
                new ColumnDefinition { Width = GridLength.Star },
                new ColumnDefinition { Width = GridLength.Star }
            }
        };
        grid.SetAppThemeColor(Grid.BackgroundColorProperty,
            Color.FromArgb("#F5F5F5"),
            Color.FromArgb("#2C2C2C"));

        var cell1 = CreateCell("Row 0, Col 0", "#E3F2FD", "#1A3A5C");
        var cell2 = CreateCell("Row 0, Col 1", "#E8F5E9", "#1A3C1A");
        var cell3 = CreateCell("Row 1, Col 0", "#FFF3E0", "#3C2A1A");
        var cell4 = CreateCell("Row 1, Col 1", "#FCE4EC", "#3C1A2A");

        Grid.SetRow(cell1, 0); Grid.SetColumn(cell1, 0);
        Grid.SetRow(cell2, 0); Grid.SetColumn(cell2, 1);
        Grid.SetRow(cell3, 1); Grid.SetColumn(cell3, 0);
        Grid.SetRow(cell4, 1); Grid.SetColumn(cell4, 1);

        grid.Children.Add(cell1);
        grid.Children.Add(cell2);
        grid.Children.Add(cell3);
        grid.Children.Add(cell4);

        return CreateDemoContainer(grid, "Equal columns using Star sizing");
    }

    private View CreateColumnDefinitionsDemo()
    {
        var stack = new VerticalStackLayout { Spacing = 15 };

        // Auto width columns
        var autoGrid = new Grid
        {
            ColumnDefinitions =
            {
                new ColumnDefinition { Width = GridLength.Auto },
                new ColumnDefinition { Width = GridLength.Auto },
                new ColumnDefinition { Width = GridLength.Auto }
            }
        };
        autoGrid.SetAppThemeColor(Grid.BackgroundColorProperty,
            Color.FromArgb("#F5F5F5"),
            Color.FromArgb("#2C2C2C"));

        var a1 = CreateCell("Auto", "#BBDEFB", "#1A3A5C");
        var a2 = CreateCell("Auto Width", "#C8E6C9", "#1A3C1A");
        var a3 = CreateCell("A", "#FFECB3", "#3C3A1A");
        Grid.SetColumn(a1, 0);
        Grid.SetColumn(a2, 1);
        Grid.SetColumn(a3, 2);
        autoGrid.Children.Add(a1);
        autoGrid.Children.Add(a2);
        autoGrid.Children.Add(a3);

        var autoLabel = new Label { Text = "Auto: Sizes to content", FontSize = 12 };
        autoLabel.SetAppThemeColor(Label.TextColorProperty,
            Color.FromArgb("#757575"),
            Color.FromArgb("#B0B0B0"));
        stack.Children.Add(autoLabel);
        stack.Children.Add(autoGrid);

        // Absolute width columns
        var absoluteGrid = new Grid
        {
            ColumnDefinitions =
            {
                new ColumnDefinition { Width = new GridLength(50) },
                new ColumnDefinition { Width = new GridLength(100) },
                new ColumnDefinition { Width = new GridLength(150) }
            }
        };
        absoluteGrid.SetAppThemeColor(Grid.BackgroundColorProperty,
            Color.FromArgb("#F5F5F5"),
            Color.FromArgb("#2C2C2C"));

        var b1 = CreateCell("50px", "#BBDEFB", "#1A3A5C");
        var b2 = CreateCell("100px", "#C8E6C9", "#1A3C1A");
        var b3 = CreateCell("150px", "#FFECB3", "#3C3A1A");
        Grid.SetColumn(b1, 0);
        Grid.SetColumn(b2, 1);
        Grid.SetColumn(b3, 2);
        absoluteGrid.Children.Add(b1);
        absoluteGrid.Children.Add(b2);
        absoluteGrid.Children.Add(b3);

        var absLabel = new Label { Text = "Absolute: Fixed pixel widths (50, 100, 150)", FontSize = 12, Margin = new Thickness(0, 10, 0, 0) };
        absLabel.SetAppThemeColor(Label.TextColorProperty,
            Color.FromArgb("#757575"),
            Color.FromArgb("#B0B0B0"));
        stack.Children.Add(absLabel);
        stack.Children.Add(absoluteGrid);

        return stack;
    }

    private View CreateRowDefinitionsDemo()
    {
        var grid = new Grid
        {
            WidthRequest = 200,
            RowDefinitions =
            {
                new RowDefinition { Height = new GridLength(30) },
                new RowDefinition { Height = new GridLength(50) },
                new RowDefinition { Height = GridLength.Auto },
                new RowDefinition { Height = new GridLength(40) }
            },
            ColumnDefinitions =
            {
                new ColumnDefinition { Width = GridLength.Star }
            }
        };
        grid.SetAppThemeColor(Grid.BackgroundColorProperty,
            Color.FromArgb("#F5F5F5"),
            Color.FromArgb("#2C2C2C"));

        var r1 = CreateCell("30px height", "#BBDEFB", "#1A3A5C");
        var r2 = CreateCell("50px height", "#C8E6C9", "#1A3C1A");
        var r3 = CreateCell("Auto height\n(fits content)", "#FFECB3", "#3C3A1A");
        var r4 = CreateCell("40px height", "#F8BBD9", "#3C1A3C");

        Grid.SetRow(r1, 0);
        Grid.SetRow(r2, 1);
        Grid.SetRow(r3, 2);
        Grid.SetRow(r4, 3);

        grid.Children.Add(r1);
        grid.Children.Add(r2);
        grid.Children.Add(r3);
        grid.Children.Add(r4);

        return CreateDemoContainer(grid, "Different row heights: 30px, 50px, Auto, 40px");
    }

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
        grid.SetAppThemeColor(Grid.BackgroundColorProperty,
            Color.FromArgb("#F5F5F5"),
            Color.FromArgb("#2C2C2C"));

        var s1 = CreateCell("1*", "#BBDEFB", "#1A3A5C");
        var s2 = CreateCell("2* (double)", "#C8E6C9", "#1A3C1A");
        var s3 = CreateCell("1*", "#FFECB3", "#3C3A1A");

        Grid.SetColumn(s1, 0);
        Grid.SetColumn(s2, 1);
        Grid.SetColumn(s3, 2);

        grid.Children.Add(s1);
        grid.Children.Add(s2);
        grid.Children.Add(s3);

        return CreateDemoContainer(grid, "Star proportions: 1* | 2* | 1* = 25% | 50% | 25%");
    }

    private View CreateSpacingDemo()
    {
        var stack = new VerticalStackLayout { Spacing = 15 };

        // No spacing
        var noSpacing = CreateSpacedGrid(0, 0);
        var noLabel = new Label { Text = "No spacing (RowSpacing=0, ColumnSpacing=0)", FontSize = 12 };
        noLabel.SetAppThemeColor(Label.TextColorProperty,
            Color.FromArgb("#757575"),
            Color.FromArgb("#B0B0B0"));
        stack.Children.Add(noLabel);
        stack.Children.Add(noSpacing);

        // With spacing
        var withSpacing = CreateSpacedGrid(10, 10);
        var withLabel = new Label { Text = "With spacing (RowSpacing=10, ColumnSpacing=10)", FontSize = 12, Margin = new Thickness(0, 10, 0, 0) };
        withLabel.SetAppThemeColor(Label.TextColorProperty,
            Color.FromArgb("#757575"),
            Color.FromArgb("#B0B0B0"));
        stack.Children.Add(withLabel);
        stack.Children.Add(withSpacing);

        return stack;
    }

    private Grid CreateSpacedGrid(int rowSpacing, int columnSpacing)
    {
        var grid = new Grid
        {
            RowSpacing = rowSpacing,
            ColumnSpacing = columnSpacing,
            RowDefinitions =
            {
                new RowDefinition { Height = GridLength.Auto },
                new RowDefinition { Height = GridLength.Auto }
            },
            ColumnDefinitions =
            {
                new ColumnDefinition { Width = GridLength.Star },
                new ColumnDefinition { Width = GridLength.Star }
            }
        };

        var c1 = CreateCell("0,0", "#BBDEFB", "#1A3A5C");
        var c2 = CreateCell("0,1", "#C8E6C9", "#1A3C1A");
        var c3 = CreateCell("1,0", "#FFECB3", "#3C3A1A");
        var c4 = CreateCell("1,1", "#F8BBD9", "#3C1A3C");

        Grid.SetRow(c1, 0); Grid.SetColumn(c1, 0);
        Grid.SetRow(c2, 0); Grid.SetColumn(c2, 1);
        Grid.SetRow(c3, 1); Grid.SetColumn(c3, 0);
        Grid.SetRow(c4, 1); Grid.SetColumn(c4, 1);

        grid.Children.Add(c1);
        grid.Children.Add(c2);
        grid.Children.Add(c3);
        grid.Children.Add(c4);

        return grid;
    }

    private View CreateSpanDemo()
    {
        var grid = new Grid
        {
            RowSpacing = 5,
            ColumnSpacing = 5,
            RowDefinitions =
            {
                new RowDefinition { Height = GridLength.Auto },
                new RowDefinition { Height = GridLength.Auto },
                new RowDefinition { Height = GridLength.Auto }
            },
            ColumnDefinitions =
            {
                new ColumnDefinition { Width = GridLength.Star },
                new ColumnDefinition { Width = GridLength.Star },
                new ColumnDefinition { Width = GridLength.Star }
            }
        };

        // Spanning header
        var header = CreateCell("ColumnSpan=3 (Header)", "#1976D2", "#0D47A1", Colors.White);
        Grid.SetRow(header, 0);
        Grid.SetColumn(header, 0);
        Grid.SetColumnSpan(header, 3);

        // Left sidebar spanning 2 rows
        var sidebar = CreateCell("RowSpan=2\n(Sidebar)", "#388E3C", "#1B5E20", Colors.White);
        Grid.SetRow(sidebar, 1);
        Grid.SetColumn(sidebar, 0);
        Grid.SetRowSpan(sidebar, 2);

        // Content cells
        var content1 = CreateCell("Content 1", "#E3F2FD", "#1A3A5C");
        Grid.SetRow(content1, 1); Grid.SetColumn(content1, 1);

        var content2 = CreateCell("Content 2", "#E8F5E9", "#1A3C1A");
        Grid.SetRow(content2, 1); Grid.SetColumn(content2, 2);

        var content3 = CreateCell("Content 3", "#FFF3E0", "#3C2A1A");
        Grid.SetRow(content3, 2); Grid.SetColumn(content3, 1);

        var content4 = CreateCell("Content 4", "#FCE4EC", "#3C1A2A");
        Grid.SetRow(content4, 2); Grid.SetColumn(content4, 2);

        grid.Children.Add(header);
        grid.Children.Add(sidebar);
        grid.Children.Add(content1);
        grid.Children.Add(content2);
        grid.Children.Add(content3);
        grid.Children.Add(content4);

        return CreateDemoContainer(grid, "Header spans 3 columns, Sidebar spans 2 rows");
    }

    private View CreateMixedSizingDemo()
    {
        var grid = new Grid
        {
            ColumnSpacing = 5,
            ColumnDefinitions =
            {
                new ColumnDefinition { Width = new GridLength(60) },
                new ColumnDefinition { Width = GridLength.Star },
                new ColumnDefinition { Width = GridLength.Auto },
                new ColumnDefinition { Width = new GridLength(60) }
            }
        };
        grid.SetAppThemeColor(Grid.BackgroundColorProperty,
            Color.FromArgb("#F5F5F5"),
            Color.FromArgb("#2C2C2C"));

        var c1 = CreateCell("60px", "#BBDEFB", "#1A3A5C");
        var c2 = CreateCell("Star (fills remaining)", "#C8E6C9", "#1A3C1A");
        var c3 = CreateCell("Auto", "#FFECB3", "#3C3A1A");
        var c4 = CreateCell("60px", "#F8BBD9", "#3C1A3C");

        Grid.SetColumn(c1, 0);
        Grid.SetColumn(c2, 1);
        Grid.SetColumn(c3, 2);
        Grid.SetColumn(c4, 3);

        grid.Children.Add(c1);
        grid.Children.Add(c2);
        grid.Children.Add(c3);
        grid.Children.Add(c4);

        return CreateDemoContainer(grid, "Mixed: 60px | Star | Auto | 60px");
    }

    private Border CreateCell(string text, string lightBgColor, string darkBgColor, Color? textColor = null)
    {
        var label = new Label
        {
            Text = text,
            FontSize = 12,
            HorizontalTextAlignment = TextAlignment.Center,
            VerticalTextAlignment = TextAlignment.Center
        };

        if (textColor != null)
        {
            label.TextColor = textColor;
        }
        else
        {
            label.SetAppThemeColor(Label.TextColorProperty,
                Colors.Black,
                Colors.White);
        }

        var border = new Border
        {
            Padding = new Thickness(10, 8),
            StrokeThickness = 0,
            Content = label
        };

        border.SetAppThemeColor(Border.BackgroundColorProperty,
            Color.FromArgb(lightBgColor),
            Color.FromArgb(darkBgColor));

        return border;
    }

    private View CreateDemoContainer(View content, string description)
    {
        var descLabel = new Label { Text = description, FontSize = 12 };
        descLabel.SetAppThemeColor(Label.TextColorProperty,
            Color.FromArgb("#757575"),
            Color.FromArgb("#B0B0B0"));

        return new VerticalStackLayout
        {
            Spacing = 5,
            Children = { descLabel, content }
        };
    }
}
