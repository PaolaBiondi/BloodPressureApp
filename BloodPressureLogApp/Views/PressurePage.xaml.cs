using BloodPressureLogApp.ViewModels;
using Microcharts;
using SkiaSharp;

namespace BloodPressureLogApp.Views;

public partial class PressurePage : ContentPage
{
    private readonly PressureLogViewModel _pressureLogViewModel;

    public PressurePage(PressureLogViewModel pressureLogViewModel)
    {
        InitializeComponent();
        _pressureLogViewModel = pressureLogViewModel;

        this.BindingContext = _pressureLogViewModel ?? throw new ArgumentNullException(nameof(PressureLogViewModel));

        chartSystolic.Chart = new LineChart
        {
            Entries = _pressureLogViewModel.entriesSystolic,
            ShowYAxisText = true
        };
        chartDiastolic.Chart = new LineChart
        {
            Entries = _pressureLogViewModel.entriesDiastolic,
            LineMode = LineMode.Straight,
            LineSize = 8,
            PointMode = PointMode.Square,
            PointSize = 18
        };
    }

    private async void btnChangePressureThreshold_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Info", "Coming soon", "OK");
    }
}