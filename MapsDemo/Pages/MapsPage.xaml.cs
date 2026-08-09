using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Devices.Sensors;
using Microsoft.Maui.Maps;

namespace MapsDemo.Pages;

public partial class MapsPage : ContentPage
{
    public MapsPage()
    {
        InitializeComponent();
        SeedMap();
    }

    private void SeedMap()
    {
        // Pins on every quick-jump target plus a couple of extras, so jumping
        // anywhere reveals at least one marker. Same XAML across platforms,
        // same `Pin` data type — just rendered through OpenMaui's
        // LinuxMapHandler when running on Linux.
        var pins = new (string label, double lat, double lon)[]
        {
            // Europe
            ("Paris",     48.8566,   2.3522),
            ("London",    51.5074,  -0.1278),
            ("Berlin",    52.5200,  13.4050),
            ("Rome",      41.9028,  12.4964),
            ("Madrid",    40.4168,  -3.7038),
            ("Moscow",    55.7558,  37.6173),
            ("Tallinn",   59.4370,  24.7536),
            // North America
            ("New York",  40.7128, -74.0060),
            ("Toronto",   43.6532, -79.3832),
            // Asia
            ("Tokyo",     35.6762, 139.6503),
            ("Seoul",     37.5665, 126.9780),
            ("Beijing",   39.9042, 116.4074),
            ("Hanoi",     21.0285, 105.8542),
            ("Bangkok",   13.7563, 100.5018),
            ("Singapore",  1.3521, 103.8198),
            // Oceania
            ("Sydney",   -33.8688, 151.2093),
        };
        foreach (var (label, lat, lon) in pins)
        {
            var pin = new Pin
            {
                Label = label,
                Location = new Location(lat, lon),
                Type = PinType.Place,
            };
            // Wire pin clicks to a status update so users see something happen
            // when they click. MAUI's IMapPin.SendMarkerClick fires this.
            pin.MarkerClicked += (s, e) =>
            {
                if (s is Pin p)
                    StatusLabel.Text = $"Pin clicked: {p.Label} ({p.Location.Latitude:F4}, {p.Location.Longitude:F4})";
            };
            Map.Pins.Add(pin);
        }

        // Trans-Siberian Railway approximation — Moscow → Yekaterinburg →
        // Novosibirsk → Irkutsk → Vladivostok. Shows up as a blue polyline.
        var route = new Polyline
        {
            StrokeColor = Color.FromArgb("#1976D2"),
            StrokeWidth = 4,
        };
        foreach (var (lat, lon) in new[]
        {
            (55.7558,  37.6173),   // Moscow
            (56.8389,  60.6057),   // Yekaterinburg
            (55.0084,  82.9357),   // Novosibirsk
            (52.2870, 104.3050),   // Irkutsk
            (43.1198, 131.8869),   // Vladivostok
        })
        {
            route.Geopath.Add(new Location(lat, lon));
        }
        Map.MapElements.Add(route);

        // Initial view: centered roughly over central Asia at zoom that
        // shows the whole Trans-Sib + most pins.
        Map.MoveToRegion(MapSpan.FromCenterAndRadius(
            new Location(45, 100),
            Distance.FromKilometers(5000)));
    }

    // --- Overlay toggles ---
    // Layer switcher: Map.MapType flows through LinuxMapHandler.MapMapType to
    // SkiaMap.LayerType (Street = OSM raster, Satellite/Hybrid = keyless Esri).
    void OnLayerStreet(object? sender, EventArgs e) => SetLayer(MapType.Street, "Street (OpenStreetMap)");
    void OnLayerSatellite(object? sender, EventArgs e) => SetLayer(MapType.Satellite, "Satellite (Esri World Imagery)");
    void OnLayerHybrid(object? sender, EventArgs e) => SetLayer(MapType.Hybrid, "Hybrid (satellite + labels)");

    void SetLayer(MapType type, string label)
    {
        Map.MapType = type;
        StatusLabel.Text = $"Layer: {label}";
    }

    // Polygon and Circle are built once and added/removed from Map.MapElements
    // at runtime, exercising LinuxMapHandler's Elements change-notification
    // path (the mapper re-runs on every collection mutation).
    private Polygon? _parkPolygon;
    private Circle? _cityCircle;

    void OnTogglePolygon(object? sender, EventArgs e)
    {
        if (_parkPolygon != null && Map.MapElements.Contains(_parkPolygon))
        {
            Map.MapElements.Remove(_parkPolygon);
            PolygonBtn.Text = "Add Polygon";
            StatusLabel.Text = "Central Park polygon removed";
            return;
        }

        if (_parkPolygon == null)
        {
            // Central Park, Manhattan — four corners of the rectangle, closed
            // automatically. Semi-transparent green fill + solid green stroke
            // (Controls.Maps.Polygon → IGeoPathMapElement + IFilledMapElement).
            _parkPolygon = new Polygon
            {
                FillColor = Color.FromArgb("#4D2E7D32"),
                StrokeColor = Color.FromArgb("#2E7D32"),
                StrokeWidth = 3,
            };
            foreach (var (lat, lon) in new[]
            {
                (40.7677, -73.9816),   // SW — Columbus Circle
                (40.8003, -73.9580),   // NW — Frederick Douglass Circle
                (40.7969, -73.9494),   // NE
                (40.7642, -73.9730),   // SE — Grand Army Plaza
            })
            {
                _parkPolygon.Geopath.Add(new Location(lat, lon));
            }
        }

        Map.MapElements.Add(_parkPolygon);
        PolygonBtn.Text = "Remove Polygon";
        MoveTo(40.7826, -73.9656, 6);
        StatusLabel.Text = "Polygon added over Central Park, New York";
    }

    void OnToggleCircle(object? sender, EventArgs e)
    {
        if (_cityCircle != null && Map.MapElements.Contains(_cityCircle))
        {
            Map.MapElements.Remove(_cityCircle);
            CircleBtn.Text = "Add Circle";
            StatusLabel.Text = "Paris circle removed";
            return;
        }

        // 5 km circle around central Paris — Radius is a ground Distance
        // (meters), not pixels, so it scales with zoom
        // (Controls.Maps.Circle → ICircleMapElement).
        _cityCircle ??= new Circle
        {
            Center = new Location(48.8566, 2.3522),
            Radius = Distance.FromKilometers(5),
            FillColor = Color.FromArgb("#40E64A19"),
            StrokeColor = Color.FromArgb("#E64A19"),
            StrokeWidth = 3,
        };

        Map.MapElements.Add(_cityCircle);
        CircleBtn.Text = "Remove Circle";
        MoveTo(48.8566, 2.3522, 15);
        StatusLabel.Text = "5 km circle added around Paris";
    }

    // --- Quick-jump handlers ---
    void OnGoParis(object? sender, EventArgs e)     => MoveTo(48.8566,   2.3522, 4000);
    void OnGoLondon(object? sender, EventArgs e)    => MoveTo(51.5074,  -0.1278, 4000);
    // Tallinn — Estonia's capital. Tighter 800 km radius so the country fills
    // the viewport rather than getting lost in a Baltic-wide frame.
    void OnGoEstonia(object? sender, EventArgs e)   => MoveTo(59.4370,  24.7536, 800);
    void OnGoNewYork(object? sender, EventArgs e)   => MoveTo(40.7128, -74.0060, 4000);
    void OnGoTokyo(object? sender, EventArgs e)     => MoveTo(35.6762, 139.6503, 4000);
    void OnGoSingapore(object? sender, EventArgs e) => MoveTo(1.3521,  103.8198, 4000);
    void OnGoSydney(object? sender, EventArgs e)    => MoveTo(-33.8688, 151.2093, 4000);
    void OnGoWorld(object? sender, EventArgs e)     => MoveTo(0, 0, 20000);

    private void MoveTo(double lat, double lon, double radiusKm)
    {
        Map.MoveToRegion(MapSpan.FromCenterAndRadius(
            new Location(lat, lon),
            Distance.FromKilometers(radiusKm)));
        StatusLabel.Text = $"Centered on ({lat:F4}, {lon:F4}) · radius {radiusKm} km";
    }
}
