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
    public class ViewPressureUseCase : IViewPressureUseCase
    {
        private readonly IPressureRepository _pressureRepository;

        public ViewPressureUseCase(IPressureRepository pressureRepository)
        {
            _pressureRepository = pressureRepository;
        }
        public async Task<Pressure> ExecuteAsync(int id) => await _pressureRepository.GetPressureById(id);

        public async Task UpdateAsync(Pressure pressure) => await _pressureRepository.Update(pressure);
    }
}
