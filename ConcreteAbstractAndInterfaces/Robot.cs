using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteAbstractAndInterfaces
{
    class Robot : Thing
    {
        public Robot(string name)
        {
            Name = name;
        }

        public bool IsTerminator { get; set; } = true;

        public override void DisplayName()
        {
            Console.WriteLine($"\nMy name is {Name}.");
        }

        public override void DisplayGreeting()
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

        public override void Eat(string food)
        {
            Console.WriteLine($"\nThe {food} are food. Robots do not eat food, stupid.");
        }

    }
}
