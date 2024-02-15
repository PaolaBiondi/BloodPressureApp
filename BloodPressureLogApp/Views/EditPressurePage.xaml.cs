namespace BloodPressureLogApp.Views;

public partial class EditPressurePage : ContentPage
{
	public EditPressurePage()
	{
		InitializeComponent();
	}

    private async void btnCancel_Clicked(object sender, EventArgs e)
    {
        await AppShell.Current.GoToAsync("..");
    }
}