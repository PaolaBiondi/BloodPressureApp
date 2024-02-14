using Microcharts;
using SkiaSharp;

namespace BloodPressureLogApp.Views;

public partial class PressurePage : ContentPage
{
	ChartEntry[] entries = new[]
	{
		new ChartEntry(212)
		{
			Label = "Day1",
			ValueLabel = "112",
			Color = SKColor.Parse("#2c3e50")
		},
        new ChartEntry(248)
        {
            Label = "Day2",
            ValueLabel = "648",
            Color = SKColor.Parse("#2c3e50")
        },
    };

	public PressurePage()
	{
		InitializeComponent();
		chartPressure.Chart = new BarChart
        {
            BackgroundColor = SKColor.Parse("#DBBBEA"),
            Entries = entries
        };
	}
}