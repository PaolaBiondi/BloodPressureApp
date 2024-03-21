using BloodPressure.Domain.Models;
using BloodPressure.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities = BloodPressure.Infrastructure.Persistence.EFC.SQLite.Entities;


namespace BloodPressure.Infrastructure.Persistence.EFC.SQLite
{
    public class PressureRepository : IPressureRepository
    {
        private readonly DataContext _dataContext;

        public PressureRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task Add(Pressure pressure)
        {
            var newPressureLog = new Entities.Pressure
            {
                Id = pressure.Id,
                Systolic = pressure.Systolic,
                Diastolic = pressure.Diastolic,
                Measured = pressure.Measured,
                Created = pressure.Created,
                Note = pressure.Note
            };

            await _dataContext.Pressures.AddAsync(newPressureLog);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var pressureToRemove = await _dataContext.Pressures.FindAsync(id);
            if (pressureToRemove != null)
            {
                _dataContext.Pressures.Remove(pressureToRemove);
                await _dataContext.SaveChangesAsync();
            }
        }

        public async Task<IList<Pressure>> GetAll(string? filter = null)
        {
            var list = new List<Entities.Pressure>();
            if (int.TryParse(filter, out var pressureFilter) && pressureFilter > 0)
            {
                list = await _dataContext.Pressures.AsNoTracking()
                                                   .Where(p => p.Systolic.Equals(filter) || p.Diastolic.Equals(filter)).ToListAsync();
            }
            else if (DateTime.TryParse(filter, out DateTime filterDate))
            {
                list = _dataContext.Pressures.AsNoTracking().AsEnumerable()
                 .Where(p => p.Measured.Date == filterDate.Date).ToList();
            }
            else
            {
                list = await _dataContext.Pressures.AsNoTracking()
                                   .ToListAsync();
            }

            var listPressure = new List<Pressure>();
            list.ForEach(i => listPressure.Add(new Pressure
            {
                Id = i.Id,
                Systolic = i.Systolic,
                Diastolic = i.Diastolic,
                Created = i.Created,
                Measured = i.Measured,
                Note = i.Note
            }));

            return listPressure.OrderByDescending(i=> i.Measured).ToList();

        }

        public async Task<Pressure> GetPressureById(int id)
        {
            try
            {
                var i = await _dataContext.Pressures.FindAsync(id) ?? new Entities.Pressure();

                return new Pressure
                {
                    Id = i.Id,
                    Systolic = i.Systolic,
                    Diastolic = i.Diastolic,
                    Created = i.Created,
                    Measured = i.Measured,
                    Note = i.Note
                };
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task Update(Pressure pressure)
        {
            var i = await _dataContext.Pressures.FindAsync(pressure.Id);
            if (i is null) return;

            i.Systolic = pressure.Systolic;
            i.Diastolic = pressure.Diastolic;
            i.Created = pressure.Created;
            i.Measured = pressure.Measured;
            i.Note = pressure.Note;

            _dataContext.Pressures.Update(i);
            await _dataContext.SaveChangesAsync();
        }
    }
}
