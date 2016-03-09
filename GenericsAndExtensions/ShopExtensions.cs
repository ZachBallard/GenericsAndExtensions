using System;

namespace GenericsAndExtensions
{
    public static class ShopExtensions
    {
        public static void ChangeTires<T>(this Shop<T> shop, IVehicle v) where T: IVehicle
        {
            
                Console.WriteLine($"\n{v} had its tires changed.");

            v.areTiresChanged = true;
        }
    }
}
