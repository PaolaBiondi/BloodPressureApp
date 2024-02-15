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
        private uint counter = 1;

        [ObservableProperty]
        ObservableCollection<Pressure> bloodPressure = new ObservableCollection<Pressure>();

        [ObservableProperty]
        string threshold = "Normal blood pressure 130/80";

        string? filterText;
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
            // TODO
        }

        [RelayCommand]
        public async Task Add()
        {
            // TODO
        }

        private async Task LoadPressureAsync(string? filterText = null)
        {
            // TODO
        }
    }
}
