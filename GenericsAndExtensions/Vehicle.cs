using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndExtensions
{
    public class Vehicle
    {
        public bool isOilChanged { get; set; } = false;
        public bool areTiresChanged { get; set; } = false;
        public bool isFilledUp { get; set; } = false;
        public string fuelType { get; set; } = "";
    }
}
