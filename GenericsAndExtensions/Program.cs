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

                var sedanShop = new Shop<Sedan>();
                var truckShop = new Shop<Truck>();
                var racecarShop = new Shop<Racecar>();

                var s = new Sedan();
                var t = new Truck();
                var r = new Racecar();


                Console.WriteLine("\nWe demonstrate generics and extensions by working on cars.");
                selection = getVehicle();

                switch (selection)
                {
                    case 1:
                        Console.WriteLine($"\nBefore: \nOil Changed = {s.isOilChanged}\nFull Tank = {s.isFilledUp}\nNew Tires = {s.areTiresChanged}");
                        sedanShop.ChangeOil(s);
                        sedanShop.FillUp(s);
                        sedanShop.ChangeTires(s);
                        Console.WriteLine($"\nAfter: \nOil Changed = {s.isOilChanged}\nFull Tank = {s.isFilledUp}\nNew Tires = {s.areTiresChanged}");
                        break;
                    case 2:
                        Console.WriteLine($"\nBefore: \nOil Changed = {t.isOilChanged}\nFull Tank = {t.isFilledUp}\nNew Tires = {t.areTiresChanged}");
                        truckShop.ChangeOil(t);
                        truckShop.FillUp(t);
                        truckShop.ChangeTires(t);
                        Console.WriteLine($"\nAfter: \nOil Changed = {t.isOilChanged}\nFull Tank = {t.isFilledUp}\nNew Tires = {t.areTiresChanged}");
                        break;
                    case 3:
                        Console.WriteLine($"\nBefore: \nOil Changed = {r.isOilChanged}\nFull Tank = {r.isFilledUp}\nNew Tires = {r.areTiresChanged}");
                        racecarShop.ChangeOil(r);
                        racecarShop.FillUp(r);
                        racecarShop.ChangeTires(r);
                        Console.WriteLine($"\nAfter: \nOil Changed = {r.isOilChanged}\nFull Tank = {r.isFilledUp}\nNew Tires = {r.areTiresChanged}");
                        break;
                    default:
                        Console.WriteLine("\nThe vehicle has been serviced!");
                        break;
                }

                Console.WriteLine("\nThanks for using Zach's Garage!");
                Console.WriteLine("> hit ENTER to go again <");
                Console.ReadLine();

                secondTime = "back ";
            }
        }

        private static int getVehicle()
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
    }
}
