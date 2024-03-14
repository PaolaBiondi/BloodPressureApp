using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodPressure.Domain.UseCases
{
    public interface IAddPressureUseCase
    {
        Task ExecuteAsync(Pressure pressure);
    }
}
