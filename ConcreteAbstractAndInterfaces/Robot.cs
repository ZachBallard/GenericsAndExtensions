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

        public bool amITerminator { get; set; } = true;

        public override void DisplayName()
        {
            Console.WriteLine($"\nMy name is {Name}.");
        }

        public override void DisplayGreeting()
        {
            Console.WriteLine($"\nBeep boop beepity boop boop!");
            if (isTerminator())
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

        public bool isTerminator()
        {
            if (amITerminator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
