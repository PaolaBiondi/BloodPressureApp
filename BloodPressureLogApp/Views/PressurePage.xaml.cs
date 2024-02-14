using Microcharts;
using SkiaSharp;

namespace BloodPressureLogApp.Views;

public partial class PressurePage : ContentPage
{
    public static ChartEntry[] entries = new[]
    {
        new ChartEntry(212)
        {
            Label = "Android",
            ValueLabel = "Value",
            Color = SKColor.Parse("#2c3e50")
        },
         new ChartEntry(248)
            {
                Label = "Android",
                ValueLabel = "648",
                Color = SKColor.Parse("#77d065")
            }
    };

    public PressurePage()
    {
        InitializeComponent();

        chartView.Chart = new BarChart
        {
            Entries = entries,
            ShowYAxisText = true,
        };
        chartView1.Chart = new LineChart
        {
            Entries = entries
        };
    }
}