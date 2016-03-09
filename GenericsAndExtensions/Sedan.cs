using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndExtensions
{
    public class Sedan : IVehicle
    {
        public Sedan()
        {
            fuelType = "Regular gas";
        }

        public override string ToString()
        {
            return "Sedan";
        }

        public bool isOilChanged { get; set; }
        public bool areTiresChanged { get; set; }
        public bool isFilledUp { get; set; }
        public string fuelType { get; set; }
    }
}
