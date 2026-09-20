namespace BlazorDemo;

/// <summary>A .NET service injected into Razor components: proves DI crosses the bridge.</summary>
public class WeatherService
{
    private static readonly string[] Summaries = { "Freezing", "Chilly", "Mild", "Warm", "Hot", "Scorching" };

    public IEnumerable<(DateOnly Date, int TempC, string Summary)> GetForecast()
    {
        var rng = new Random(42);
        return Enumerable.Range(1, 5).Select(i => (
            DateOnly.FromDateTime(DateTime.Now.AddDays(i)),
            rng.Next(-5, 35),
            Summaries[rng.Next(Summaries.Length)]));
    }
}
