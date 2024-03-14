using BloodPressure.Domain.UseCases;
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
        public PressureViewModel(IAddPressureUseCase addPressureUseCase, IViewPressureUseCase viewPressureUseCase)
        {
            _addPressureUseCase = addPressureUseCase;
            _viewPressureUseCase = viewPressureUseCase;
        }

        public Action? ToHideKeyboard = null;

        [ObservableProperty]
        Pressure? pressure = new() { Measured = DateTimeOffset.Now};
        
        private readonly IAddPressureUseCase _addPressureUseCase;
        private readonly IViewPressureUseCase _viewPressureUseCase;

        public DateTime MinDate { get; set; } = DateTime.Now.AddYears(-30);
        public DateTime MaxDate { get; set; } = DateTime.Now;
        public TimeSpan MeasuredTime { get; set; } = DateTimeOffset.Now.TimeOfDay;
        public bool IsSystolicProvided { get; set; }
        public bool IsDiastolicProvided { get; set; }

        [RelayCommand]
        public async Task Add()
        {
            if (!(await ValidatePressure()))
                return;

            await _addPressureUseCase.ExecuteAsync(this.Pressure!);
            await Shell.Current.GoToAsync("..");

            await OnClose();
        }

        [RelayCommand]
        public async Task Save()
        {
            if (!(await ValidatePressure()))
                return;

            await _viewPressureUseCase.UpdateAsync(this.Pressure!);

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

        private async Task<bool> ValidatePressure()
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

        public async Task LoadPressure(int id)
        {
            this.Pressure = await _viewPressureUseCase.ExecuteAsync(id);
        }

        private async Task DisplayMessage(string message)
        {
            await Application.Current?.MainPage?.DisplayAlert("Error", message, "OK")!;
        }
    }
}
