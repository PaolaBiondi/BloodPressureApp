using CommunityToolkit.Maui.Core.Platform;

namespace BloodPressureLogApp.Views.Components;

public partial class BloodPressureComponent : ContentView
{
    public event EventHandler<EventArgs>? OnSave;
    public event EventHandler<EventArgs>? OnCancel;
    public event EventHandler<string>? OnError;

    public BloodPressureComponent()
	{
		InitializeComponent();
	}

    private void btnSave_Clicked(object sender, EventArgs e)
    {
        HideKeyboard();
        OnSave?.Invoke(this, EventArgs.Empty);
    }

    private void btnCancel_Clicked(object sender, EventArgs e)
    {
        HideKeyboard();
        OnCancel?.Invoke(this, EventArgs.Empty);
    }

    private void HideKeyboard()
    {
        try
        {
            systolic.HideKeyboardAsync();
        }
        catch { }
    }
}