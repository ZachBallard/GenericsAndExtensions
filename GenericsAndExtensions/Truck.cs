using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndExtensions
{
    public class Truck : IVehicle
    {
        public Truck()
        {
            fuelType = "Diesel fuel";
        }

        public override string ToString()
        {
            return "Truck";
        }

        public bool isOilChanged { get; set; }
        public bool areTiresChanged { get; set; }
        public bool isFilledUp { get; set; }
        public string fuelType { get; set; }
    }
}
