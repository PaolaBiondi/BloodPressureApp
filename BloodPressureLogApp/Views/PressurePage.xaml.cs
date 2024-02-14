using Microcharts;
using SkiaSharp;

namespace BloodPressureLogApp.Views;

public partial class PressurePage : ContentPage
{
    public static ChartEntry[] entriesSystolic = new[]
    {
        new ChartEntry(139)
        {
            Label = "14-2-2024",
            ValueLabel = "Date",
            Color = SKColor.Parse("#2c3e50")
        },
         new ChartEntry(160)
            {
                Label = "13-2-2024",
                ValueLabel = "Date",
                Color = SKColor.Parse("#77d065")
            }
    };

    public static ChartEntry[] entriesDiastolic = new[]
{
        new ChartEntry(89)
        {
            Label = "14-2-2024",
            ValueLabel = "Date",
            Color = SKColor.Parse("#2c3e50")
        },
         new ChartEntry(85)
            {
                Label = "13-2-2024",
                ValueLabel = "Date",
                Color = SKColor.Parse("#77d065")
            }
    };

    public PressurePage()
    {
        InitializeComponent();

        chartSystolic.Chart = new BarChart
        {
            Entries = entriesSystolic,
            ShowYAxisText = true
        };
        chartDiastolic.Chart = new LineChart
        {
            Entries = entriesDiastolic,
            LineMode = LineMode.Straight,
            LineSize = 8,
            PointMode = PointMode.Square,
            PointSize = 18
        };
    }
}