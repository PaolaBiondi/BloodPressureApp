using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodPressure.Infrastructure.Persistence.EFC.SQLite.Extensions
{
    public static class CustomExtensions
    {
        public static IServiceCollection AddCustomDbContext(this IServiceCollection services)
        {
            services.AddDbContext<DataContext>(o => o.UseSqlite($"FileName={Constants.DatabasePath}"));

            var options = new DbContextOptionsBuilder<DataContext>().UseSqlite($"FileName={Constants.DatabasePath}").Options;

            using var context = new DataContext(options);
            context.Database.EnsureCreated();

            return services;
        }
    }
}
