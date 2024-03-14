using BloodPressure.Domain.Models;
using BloodPressure.Domain.Repositories;
using BloodPressure.Domain.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodPressure.UseCases
{
    public class ViewBloodPressuresUseCase : IViewBloodPressuresUseCase
    {
        private readonly IPressureRepository _pressureRepository;

        public ViewBloodPressuresUseCase(IPressureRepository pressureRepository)
        {
            _pressureRepository = pressureRepository;
        }

        public async Task DeleteAsync(int id)
        {
            await _pressureRepository.Delete(id);
        }

        public async Task<IList<Pressure>> ExecuteAsync(string? filter = null)
        {
            return await _pressureRepository.GetAll(filter);
        }
    }
}
