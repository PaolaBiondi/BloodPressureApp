using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodPressure.Domain.Models
{
    public sealed class Pressure
    {
        public int Id { get; set; }
        public int Systolic {  get; set; }
        public int Diastolic { get; set; }
        public DateTimeOffset Measured { get; set; }
        public DateTimeOffset Created { get; set; } = DateTimeOffset.Now;
    }
}
