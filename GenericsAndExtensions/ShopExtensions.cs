using System;

namespace GenericsAndExtensions
{
    public static class ShopExtensions
    {
        public static void ChangeTires<T>(this Shop<T> shop, Vehicle v) where T: Vehicle
        {
            if (v is Racecar)
            {
                Console.WriteLine($"\nThe Race Car had its tires changed.");
            }
            else if (v is Truck)
            {
                Console.WriteLine($"\nThe Truck had its tires changed.");
            }
            else
            {
                Console.WriteLine($"\nThe Sedan had its tires changed.");
            }

            v.areTiresChanged = true;
        }
    }
}
