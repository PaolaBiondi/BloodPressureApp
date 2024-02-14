using BloodPressureLogApp.Views;

namespace BloodPressureLogApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(EditBloodThresholdPage), typeof(EditBloodThresholdPage));
        }
    }
}
