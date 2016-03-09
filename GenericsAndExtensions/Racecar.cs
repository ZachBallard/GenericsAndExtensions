using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndExtensions
{
    public class Racecar : IVehicle
    {
        public Racecar()
        {
            fuelType = "High Performance gas";
        }

        public bool isOilChanged { get; set; }
        public bool areTiresChanged { get; set; }
        public bool isFilledUp { get; set; }
        public string fuelType { get; set; }

        public override string ToString()
        {
            return "Race Car";
        }
    }
}
