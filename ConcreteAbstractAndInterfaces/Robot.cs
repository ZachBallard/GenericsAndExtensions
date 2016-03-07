using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteAbstractAndInterfaces
{
    class Robot
    {
        public string Name { get; set; } = "Extremely the sad Robot";
        public bool IsTerminator { get; set; } = true;
        public bool IsAsleep { get; set; } = false;

        public void DisplayName()
        {
            Console.WriteLine($"\nMy name is {Name}.");
        }

        public void DisplayGreeting()
        {
            Console.WriteLine($"\nBeep boop beepity boop boop!");
            if (IsTerminator)
            {
                Console.WriteLine($"Can't wait to kill Steve!");
            }
        }

        public void StartUp()
        {
            if (IsAsleep == true)
            {
                Console.WriteLine($"\n{Name} is starting up...");
                IsAsleep = false;
            }
            else
            {
                Console.WriteLine($"\n{Name} is already booted up!");
            }
        }

        public void ShutDown()
        {
            if (IsAsleep == false)
            {
                Console.WriteLine($"\n{Name} is shutting down...");
                IsAsleep = true;
            }
            else
            {
                Console.WriteLine($"\n{Name} is already shutdown!");
            }
        }

        public void Eat(string food)
        {
            Console.WriteLine($"\nThe {food} are food. Robots do not eat food, stupid.");
        }

    }
}
