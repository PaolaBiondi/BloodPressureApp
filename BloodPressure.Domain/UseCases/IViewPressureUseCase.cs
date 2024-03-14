using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodPressure.Domain.UseCases
{
    public interface IViewPressureUseCase
    {
        Task<Pressure> ExecuteAsync(int id);
        Task UpdateAsync(Pressure pressure);
    }
}
