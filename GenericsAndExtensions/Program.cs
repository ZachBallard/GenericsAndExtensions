using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopExtensions;

namespace GenericsAndExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection = 0;
            string secondTime = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"\nWelcome {secondTime}to Zach's Garage!");

                var shop = new Shop<Vehicle>();
                var sedanShop = new Shop<Sedan>();
                var truckShop = new Shop<Truck>();
                var racecarShop = new Shop<Racecar>();

                var s = new Sedan();
                var t = new Truck();
                var r = new Racecar();


                Console.WriteLine("\nWe demonstrate generics and extensions by working on cars.");
                selection = GetVehicle();

                switch (selection)
                {
                    case 1:
                        DoThings(s, shop);
                        break;
                    case 2:
                        DoThings(t, shop);
                        break;
                    case 3:
                        DoThings(r, shop);
                        break;
                   
                };

                Console.WriteLine("\nThanks for using Zach's Garage!");
                Console.WriteLine("> hit ENTER to go again <");
                Console.ReadLine();

                secondTime = "back ";
            }
        }

        public static int GetVehicle()
        {
            string userInput = "";

            while (true)
            {
                Console.WriteLine("\nWould you like to send us a (s)edan, (t)ruck, or (r)acecar?");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "s":
                        return 1;
                    case "t":
                        return 2;
                    case "r":
                        return 3;
                    default:
                        Console.WriteLine("\nWe dont work on that type of vehicle! Try another.");
                        break;
                }
            }
        }

        public static void DoThings(Vehicle vehicle, Shop<Vehicle> shop)
        {
            Console.WriteLine($"\nBefore: \nOil Changed = {vehicle.isOilChanged}\nFull Tank = {vehicle.isFilledUp}\nNew Tires = {vehicle.areTiresChanged}");
            shop.ChangeOil(vehicle);
            shop.FillUp(vehicle);
            shop.ChangeTires(vehicle);
            Console.WriteLine($"\nAfter: \nOil Changed = {vehicle.isOilChanged}\nFull Tank = {vehicle.isFilledUp}\nNew Tires = {vehicle.areTiresChanged}");

            Console.WriteLine("\nThe vehicle has been serviced!");
        }
    }
}
