using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aircompany.Models
{
    public class PlaneSpecification
    {
        public string Model { get; set; }
        public int MaxSpeed { get; set; }
        public int MaxFlightDistance { get; set; }
        public int MaxLoadCapacity { get; set; }
    }
}
