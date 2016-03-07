using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteAbstractAndInterfaces
{
    class Panda
    {
        public string Name { get; set; }
        public bool IsAsleep { get; set; }

        public void DisplayName()
        {
            Console.WriteLine($"My name is {Name}");
        }

        public void DisplayGreeting()
        {
            Console.WriteLine($"*Noise typical of pandas*");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"Yum, {Name} ate {food}");
        }

        public void GoToSleep()
        {
            Console.WriteLine($"{Name} starts to fall asleep...");
            IsAsleep = true;
        }

        public void WakeUp()
        {
            Console.WriteLine($"...{Name} has woken up!");
            IsAsleep = false;
        }
    }
}
