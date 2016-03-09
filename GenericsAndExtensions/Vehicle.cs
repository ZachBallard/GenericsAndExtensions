using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndExtensions
{
    public interface IVehicle
    {
        bool isOilChanged { get; set; }
        bool areTiresChanged { get; set; }
        bool isFilledUp { get; set; }
        string fuelType { get; set; }
    }
}
