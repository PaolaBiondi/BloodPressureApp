using BloodPressureLogApp.Views;

namespace BloodPressureLogApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(AddPressurePage), typeof(AddPressurePage));
            Routing.RegisterRoute(nameof(EditPressurePage), typeof (EditPressurePage));
        }
    }
}
