using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodPressureLogApp.ViewModels
{
    public partial class PressureViewModel : ObservableObject
    {

        public Action? ToHideKeyboard = null;

        [ObservableProperty]
        Pressure? pressure = new();

        public DateTime MinDate { get; set; } = DateTime.Now.AddYears(-30);
        public DateTime MaxDate { get; set; } = DateTime.Now;
        public TimeOnly MeasuredTime { get; set; } = TimeOnly.FromDateTime(DateTime.Now);
        public bool IsSystolicProvided { get; set; }
        public bool IsDiastolicProvided { get; set; }

        [RelayCommand]
        public async Task Add()
        {
            if (!(await ValidateContact()))
                return;

            await OnClose();
        }

        [RelayCommand]
        public async Task Save()
        {
            if (!(await ValidateContact()))
                return;
            // TODO save to DB 

            await OnClose();
        }

        [RelayCommand]
        public async Task Cancel()
        {
            await OnClose();
        }

        private async Task OnClose()
        {
            ToHideKeyboard?.Invoke();
            await AppShell.Current.GoToAsync("..");
        }

        private async Task<bool> ValidateContact()
        {
            if (!IsSystolicProvided)
            {
                await DisplayMessage($"{nameof(this.Pressure.Systolic)} is not provided");
                return false;
            }

            if (!IsDiastolicProvided)
            {
                await DisplayMessage($"{nameof(this.Pressure.Diastolic)} is not provided");
                return false;
            }

            return true;
        }

        private async Task DisplayMessage(string message)
        {
            await Application.Current?.MainPage?.DisplayAlert("Error", message, "OK")!;
        }
    }
}
