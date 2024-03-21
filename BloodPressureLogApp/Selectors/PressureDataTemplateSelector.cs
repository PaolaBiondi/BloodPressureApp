using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodPressureLogApp.Selectors
{
    public class PressureDataTemplateSelector : DataTemplateSelector
    {
        private static Threshold? _threshold;

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            _threshold ??= Application.Current?.MainPage!.Handler?.MauiContext?.Services.GetService<Threshold>() ?? throw new ArgumentNullException("Default threshold blood pressure values unknow");
            if (item is Pressure pressure)
            {

                if (pressure.Systolic < _threshold.Systolic && pressure.Diastolic < _threshold.Diastolic)
                {
                    Application.Current!.Resources.TryGetValue("PressureItemStyle", out var dtPressure);
                    return dtPressure as DataTemplate ?? new DataTemplate();
                }

                Application.Current!.Resources.TryGetValue("WarningPressureItemStyle", out var dtWarning);
                return dtWarning as DataTemplate ?? new DataTemplate();
            }

            return new DataTemplate();
        }
    }
}
