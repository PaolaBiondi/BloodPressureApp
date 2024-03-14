using BloodPressure.Domain.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodPressure.Domain.Models;
using BloodPressure.Domain.Repositories;

namespace BloodPressure.UseCases
{
    public class AddPressureUseCase : IAddPressureUseCase
    {
        private readonly IPressureRepository _pressureRepository;

        public AddPressureUseCase(IPressureRepository pressureRepository)
        {
            _pressureRepository = pressureRepository;
        }
        public async Task ExecuteAsync(Pressure pressure)
        {
            await _pressureRepository.Add(pressure);
        }
    }
}
