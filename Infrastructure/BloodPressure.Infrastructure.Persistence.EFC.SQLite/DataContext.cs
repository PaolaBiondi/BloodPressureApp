using BloodPressure.Infrastructure.Persistence.EFC.SQLite.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodPressure.Infrastructure.Persistence.EFC.SQLite
{
    public sealed class DataContext : DbContext
    {
        public DbSet<Pressure> Pressures { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {
        }
    }
}
