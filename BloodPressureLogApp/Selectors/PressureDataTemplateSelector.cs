using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodPressureLogApp.Selectors
{
    public class PressureDataTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var pressure = item as Pressure;

            if (pressure?.Systolic > 120)
            {
                Application.Current!.Resources.TryGetValue("PressureItemStyle", out var dtPressure);
                return dtPressure as DataTemplate ?? new DataTemplate();
            }

            Application.Current!.Resources.TryGetValue("WarningPressureItemStyle", out var dtWarning);
            return dtWarning as DataTemplate ?? new DataTemplate();
        }
    }
}
