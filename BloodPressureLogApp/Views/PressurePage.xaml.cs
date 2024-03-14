using BloodPressureLogApp.ViewModels;

namespace BloodPressureLogApp.Views;

public partial class PressurePage : ContentPage
{
    private readonly PressureLogViewModel _pressureLogViewModel;

    public PressurePage(PressureLogViewModel pressureLogViewModel)
    {
        InitializeComponent();
        _pressureLogViewModel = pressureLogViewModel;

        this.BindingContext = _pressureLogViewModel ?? throw new ArgumentNullException(nameof(PressureLogViewModel));
    }

    private async void btnChangePressureThreshold_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Info", "Coming soon", "OK");
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _pressureLogViewModel.LoadPressureAsync();
    }
}