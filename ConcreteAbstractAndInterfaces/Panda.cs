using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteAbstractAndInterfaces
{
    class Panda
    {
        public string Name { get; set; } = "Dentalfloss the Panda";
        public bool IsAsleep { get; set; }

        public void DisplayName()
        {
            Console.WriteLine($"\nMy name is {Name}");
        }

        public void DisplayGreeting()
        {
            Console.WriteLine($"\n*Noise typical of pandas*");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"\nYum, {Name} ate a {food}");
        }

        public void GoToSleep()
        {
            if (IsAsleep == false)
            {
                Console.WriteLine($"\n{Name} starts to fall asleep...");
                IsAsleep = true;
            }
            else
            {
                Console.WriteLine($"\n{Name} is already asleep!");
            }
        }

        public void WakeUp()
        {
            if (IsAsleep == true)
            {
                Console.WriteLine($"\n{Name} has woken up...");
                IsAsleep = true;
            }
            else
            {
                Console.WriteLine($"\n{Name} is already awake!");
            }
        }
    }
}
