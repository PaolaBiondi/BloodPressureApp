using BloodPressureLogApp.ViewModels;

namespace BloodPressureLogApp.Views;

public partial class AddPressurePage : ContentPage
{
    private readonly PressureViewModel _pressureViewModel;

    public AddPressurePage(PressureViewModel pressureViewModel)
	{
		InitializeComponent();
        _pressureViewModel = pressureViewModel;
        //_pressureViewModel.ToHideKeyboard = 
        this.BindingContext = _pressureViewModel;
    }
}