using CommunityToolkit.Maui.Core.Platform;
using System.Runtime.CompilerServices;

namespace BloodPressureLogApp.Views.Components;

public partial class PressureComponent : ContentView
{
	public bool IsEdit { get; set; } = false;

	public PressureComponent()
	{
		InitializeComponent();
	}

    protected override void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        base.OnPropertyChanged(propertyName);
        if (IsLoaded == false) return;

        if (IsEdit)
        {
            btnSave.SetBinding(Button.CommandProperty, "SaveCommand");
            return;
        }

        btnSave.SetBinding(Button.CommandProperty, "AddCommand");
    }

    public void HideKeyboard()
    {
        if (entrySystolic.IsSoftKeyboardShowing())
            entrySystolic.HideKeyboardAsync();
    }
}