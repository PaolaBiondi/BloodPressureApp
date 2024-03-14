using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodPressure.Infrastructure.Persistence.EFC.SQLite
{
    public class Constants
    {
        public const string DatabaseFileName = "BloodPressure_v1.db3";

        public static string DatabasePath => Path.Combine(FileSystem.AppDataDirectory, DatabaseFileName);
    }
}
