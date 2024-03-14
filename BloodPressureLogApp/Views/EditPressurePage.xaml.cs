using BloodPressureLogApp.ViewModels;

namespace BloodPressureLogApp.Views;

[QueryProperty(nameof(PressureId), "Id")]
public partial class EditPressurePage : ContentPage
{
    private readonly PressureViewModel _pressureViewModel;

    public EditPressurePage(PressureViewModel pressureViewModel)
	{
		InitializeComponent();
        _pressureViewModel = pressureViewModel;
        _pressureViewModel.ToHideKeyboard = editPressure.HideKeyboard;

        BindingContext = _pressureViewModel;
    }

    public int PressureId
    {
        set
        {
            LoadPressure(value);
        }
    }

    private async Task LoadPressure(int id)
    {
        await _pressureViewModel.LoadPressure(id);
    }

    private async void btnCancel_Clicked(object sender, EventArgs e)
    {
        await AppShell.Current.GoToAsync("..");
    }
}