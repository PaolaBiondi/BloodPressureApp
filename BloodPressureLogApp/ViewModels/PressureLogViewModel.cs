using BloodPressureLogApp.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microcharts;
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
        public PressureLogViewModel(Threshold threshold)
        {
            _threshold = threshold;
            this.threshold = $"Normal blood pressure {_threshold.Systolic}/{_threshold.Diastolic}";
        }

        public ChartEntry[] entriesSystolic = new[]
        {
            new ChartEntry(139)
            {
                Label = "14-2-2024",
                ValueLabel = "Date",
                Color = SKColor.Parse("#2c3e50")
            },
             new ChartEntry(160)
                {
                    Label = "13-2-2024",
                    ValueLabel = "Date",
                    Color = SKColor.Parse("#77d065")
                }
        };

        public ChartEntry[] entriesDiastolic = new[]
        {
            new ChartEntry(89)
            {
                Label = "14-2-2024",
                ValueLabel = "Date",
                Color = SKColor.Parse("#2c3e50")
            },
             new ChartEntry(85)
                {
                    Label = "13-2-2024",
                    ValueLabel = "Date",
                    Color = SKColor.Parse("#77d065")
                }
        };

        [ObservableProperty]
        ObservableCollection<Pressure>? bloodPressure = null;
        //    new ObservableCollection<Pressure>()
        //{
        //    new Pressure
        //    {
        //        Id= 1,
        //        Systolic = 130,
        //        Diastolic = 80,
        //        Measured = DateTimeOffset.Now.AddDays(-14)
        //    }
        //};

        [ObservableProperty]
        string threshold = string.Empty;

        string? filterText;
        private readonly Threshold _threshold;

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
        public async Task EditPressureThreshold()
        {
            await AppShell.Current.GoToAsync(nameof(EditBloodThresholdPage));
        }

        [RelayCommand]
        public async Task Delete(int id)
        {
            // TODO
        }

        [RelayCommand]
        public async Task Edit(int id)
        {
            await AppShell.Current.GoToAsync(nameof(EditPressurePage));
        }

        [RelayCommand]
        public async Task Add()
        {
            await AppShell.Current.GoToAsync(nameof(AddPressurePage));
        }

        private async Task LoadPressureAsync(string? filterText = null)
        {
            // TODO
        }
    }
}
