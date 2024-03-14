using BloodPressure.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodPressure.Domain.UseCases
{
    public interface IViewBloodPressuresUseCase
    {
        Task<IList<Pressure>> ExecuteAsync(string? filter = null);
        Task DeleteAsync(int id);
    }
}
