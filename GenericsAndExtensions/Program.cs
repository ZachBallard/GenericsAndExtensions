using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndExtensions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var secondTime = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"\nWelcome {secondTime}to Zach's Garage!");

                var shop = new Shop<Vehicle>();

                Console.WriteLine("\nWe demonstrate generics and extensions by working on cars.");
                var selection = GetVehicle();

                switch (selection)
                {
                    case 1:
                        DoThings(new Sedan(), shop);
                        break;
                    case 2:
                        DoThings(new Truck(), shop);
                        break;
                    case 3:
                        DoThings(new Racecar(), shop);
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
            while (true)
            {
                Console.WriteLine("\nWould you like to send us a (s)edan, (t)ruck, or (r)acecar?");
                var userInput = Console.ReadLine();

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
