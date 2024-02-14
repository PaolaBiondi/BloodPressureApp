using BloodPressureLogApp.ViewModels;
using BloodPressureLogApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodPressureLogApp.Extensions
{
    public static class CustomExtensions
    {
        public static IServiceCollection AddAppPages(this IServiceCollection services)
        {
            services.AddSingleton<PressureLogViewModel>();
            services.AddSingleton<PressurePage>();
            services.AddSingleton<EditBloodThresholdPage>();
            return services;
        }

    }
}
