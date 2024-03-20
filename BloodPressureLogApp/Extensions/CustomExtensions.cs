using BloodPressure.Domain.Repositories;
using BloodPressure.Domain.UseCases;
using BloodPressure.Infrastructure.Persistence.EFC.SQLite;
using BloodPressure.UseCases;
using BloodPressureLogApp.ViewModels;
using BloodPressureLogApp.Views;
using CommunityToolkit.Maui;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BloodPressureLogApp.Extensions
{
    public static class CustomExtensions
    {
        public static IServiceCollection AddAppPages(this IServiceCollection services)
        {
            services.AddSingleton(LoadMauiAsset().Result);

            services.AddTransient<IPressureRepository, PressureRepository>();

            services.AddSingleton<PressurePage>();
            services.AddSingleton<EditBloodThresholdPage>();
            services.AddTransient<AddPressurePage>();
            services.AddSingleton<EditPressurePage>();

            services.AddSingleton<PressureLogViewModel>();
            services.AddTransient<PressureViewModel>();

            services.AddSingleton<IViewBloodPressuresUseCase, ViewBloodPressuresUseCase>();
            services.AddTransient<IAddPressureUseCase, AddPressureUseCase>();
            services.AddTransient<IViewPressureUseCase, ViewPressureUseCase>();

            return services;
        }

        public static async Task<Threshold> LoadMauiAsset()
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync("threshold.json");
            using var reader = new StreamReader(stream);

            var contents = reader.ReadToEnd();

            var threshold = JsonSerializer.Deserialize<Threshold>(contents, new JsonSerializerOptions { PropertyNameCaseInsensitive = true});
            return threshold;
        }
    }
}
