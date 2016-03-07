using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteAbstractAndInterfaces
{
    class Robot
    {
        public string Name { get; set; }
        public bool IsTerminator { get; set; }
        public bool IsAsleep { get; set; }

        public void DisplayName()
        {
            Console.WriteLine($"My name is {Name}");
        }

        public void DisplayGreeting()
        {
            Console.WriteLine($"Beep boop beepity boop boop!");
        }

        public void StartUp()
        {
            Console.WriteLine($"{Name} is starting up...");
            IsAsleep = false;
        }

        public void ShutDown()
        {
            Console.WriteLine($"{Name} is shutting down...");
            IsAsleep = true;
        }

        public void Eat(string food)
        {
            Console.WriteLine($"Robots do not eat food. Stupid.");
        }

    }
}
