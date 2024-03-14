using BloodPressure.Domain.Models;

namespace BloodPressure.Domain.Repositories
{
    public interface IPressureRepository
    {
        public Task<Pressure> GetPressureById(int id);
        public Task Update(Pressure pressure);
        public Task Add(Pressure pressure);
        public Task Delete(int id);
        public Task<IList<Pressure>> GetAll(string? filter = null);
    }
}
