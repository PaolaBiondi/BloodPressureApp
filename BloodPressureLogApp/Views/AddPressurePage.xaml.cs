namespace BloodPressureLogApp.Views;

public partial class AddPressurePage : ContentPage
{
	public AddPressurePage()
	{
		InitializeComponent();
	}

    private async void btnCancel_Clicked(object sender, EventArgs e)
    {
		await AppShell.Current.GoToAsync("..");
    }
}