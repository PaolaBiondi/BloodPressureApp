using BloodPressure.Domain.UseCases;
using BloodPressureLogApp.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodPressureLogApp.ViewModels
{
    public partial class PressureLogViewModel : ObservableObject
    {
        public PressureLogViewModel(Threshold threshold, IViewBloodPressuresUseCase viewBloodPressuresUseCase)
        {
            _threshold = threshold;
            _viewBloodPressuresUseCase = viewBloodPressuresUseCase;
            this.threshold = $"Normal blood pressure {_threshold.Systolic}/{_threshold.Diastolic} mmHg";
            this.UpperThreshold = _threshold.Systolic;
            this.BottomThreshold = _threshold.Diastolic;

        }

        [ObservableProperty]
        ObservableCollection<Pressure>? bloodPressure = //null;
            new ObservableCollection<Pressure>()
        {
            new Pressure
            {
                Id= 1,
                Systolic = 130,
                Diastolic = 80,
                Measured = DateTimeOffset.Now.AddDays(-14)
            },
                        new Pressure
            {
                Id= 1,
                Systolic = 130,
                Diastolic = 70,
                Measured = DateTimeOffset.Now.AddDays(-14)
            },            new Pressure
            {
                Id= 1,
                Systolic = 130,
                Diastolic = 60,
                Measured = DateTimeOffset.Now.AddDays(-14)
            },            new Pressure
            {
                Id= 1,
                Systolic = 130,
                Diastolic = 50,
                Measured = DateTimeOffset.Now.AddDays(-14)
            },            new Pressure
            {
                Id= 1,
                Systolic = 130,
                Diastolic = 40,
                Measured = DateTimeOffset.Now.AddDays(-14)
            },            new Pressure
            {
                Id= 1,
                Systolic = 130,
                Diastolic = 30,
                Measured = DateTimeOffset.Now.AddDays(-14)
            },            new Pressure
            {
                Id= 1,
                Systolic = 130,
                Diastolic = 20,
                Measured = DateTimeOffset.Now.AddDays(-14)
            },
        };

        [ObservableProperty]
        string threshold = string.Empty;

        string? filterText;
        private readonly Threshold _threshold;
        [ObservableProperty]
        private uint upperThreshold;
        [ObservableProperty]
        private uint bottomThreshold;

        private readonly IViewBloodPressuresUseCase _viewBloodPressuresUseCase;

        public string? FilterText
        {
            get => filterText;
            set
            {
                filterText = value;
                LoadPressureAsync(value);
            }
        }

        [RelayCommand]
        public async Task Delete(int id)
        {
            await _viewBloodPressuresUseCase.DeleteAsync(id);
            await LoadPressureAsync();
        }

        [RelayCommand]
        public async Task Edit(int id)
        {
            await AppShell.Current.GoToAsync($"{nameof(EditPressurePage)}?Id={id}");

        }

        [RelayCommand]
        public async Task Add()
        {
            await AppShell.Current.GoToAsync(nameof(AddPressurePage));
        }

        [ObservableProperty]
        public bool isRefreshing;

        [RelayCommand]
        public async Task TriggeredRefresh()
        {
            await LoadPressureAsync();
            this.IsRefreshing = false;
        }

        public async Task LoadPressureAsync(string? filterText = null)
        {
            this.BloodPressure?.Clear();
            var list = await _viewBloodPressuresUseCase.ExecuteAsync(filterText);
            if (list is not null)
            {
                foreach (var item in list)
                {
                    this.BloodPressure ??= new ObservableCollection<Pressure>();
                    this.BloodPressure.Add(item);
                }
            }
        }
    }
}
