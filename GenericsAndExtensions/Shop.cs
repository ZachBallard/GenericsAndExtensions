using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndExtensions
{
    public class Shop<T> where T : Vehicle
    {
        public void ChangeOil(T vehicle)
        {
            if (vehicle is Racecar)
            {
                Console.WriteLine($"\nThe Race Car had its oil changed.");
            }
            else if (vehicle is Truck)
            {
                Console.WriteLine($"\nThe Truck had its oil changed.");
            }
            else
            {
                Console.WriteLine($"\nThe Sedan had its oil changed.");
            }

            vehicle.isOilChanged = true;
        }

        public void FillUp(T vehicle)
        {
            if (vehicle is Racecar)
            {
                Console.WriteLine($"\nThe Race Car was filled with {vehicle.fuelType}.");
            }
            else if (vehicle is Truck)
            {
                Console.WriteLine($"\nThe Truck was filled with {vehicle.fuelType}.");
            }
            else
            {
                Console.WriteLine($"\nThe Sedan was filled with {vehicle.fuelType}.");
            }

            vehicle.isFilledUp = true;
        }
    }

}
