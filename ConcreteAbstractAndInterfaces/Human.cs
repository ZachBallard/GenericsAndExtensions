﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteAbstractAndInterfaces
{
    class Human : Thing, INotARobot
    {
        public Human(string name)
        {
            Name = name;
        }

        public override void DisplayName()
        {
            Console.WriteLine($"\nMy name is {Name}");
        }

        public override void DisplayGreeting()
        {
            Console.WriteLine($"\nI think therefore I am and stuff!");
        }

        public override void Eat(string food)
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
