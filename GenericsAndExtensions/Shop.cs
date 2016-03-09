using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndExtensions
{
    public class Shop<T> where T : IVehicle
    {
        public void ChangeOil(T vehicle)
        {
            Console.WriteLine($"\n{vehicle} had its oil changed.");

            vehicle.isOilChanged = true;
        }

        public void FillUp(T vehicle)
        {

            Console.WriteLine($"\n{vehicle} was filled with {vehicle.fuelType}.");

            vehicle.isFilledUp = true;
        }
    }

}
