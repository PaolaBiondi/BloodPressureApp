namespace BloodPressureLogApp.Views;

public partial class EditBloodThresholdPage : ContentPage
{
	public EditBloodThresholdPage()
	{
		InitializeComponent();
	}

    private async void btnUpdate_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private async void btnCancel_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}