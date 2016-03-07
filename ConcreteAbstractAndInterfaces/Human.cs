using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteAbstractAndInterfaces
{
    class Human
    {
        public string Name { get; set; } = "Steve";
        public bool IsAsleep { get; set; } = false;

        public void DisplayName()
        {
            Console.WriteLine($"My name is {Name}");
        }

        public void DisplayGreeting()
        {
            Console.WriteLine($"I think therefore I am and stuff!");
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
