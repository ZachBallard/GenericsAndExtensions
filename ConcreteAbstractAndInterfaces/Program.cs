using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteAbstractAndInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var panda = new Panda();
            var human = new Human();
            var robot = new Robot();

            int objectSelected = 0;
            int whichAction = 0;

            Console.WriteLine("Welcome to a really strange room containing a Human, a Robot, and a Panda!");

            objectSelected = Select();

            whichAction = WhatAction();

        }

        private static int Select()
        {
            string userInput = "";

            while (true)
            {
                Console.WriteLine("You can make them do some stuff. Would you like to mess with...");
                Console.WriteLine("The (h)uman, the (r)obot, or the (p)anda?");

                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "h":
                        return 1;
                    case "r":
                        return 2;
                    case "p":
                        return 3;
                    default:
                        Console.WriteLine("\nThat isn't a valid selection! Try again.");
                        break;
                };
            }

        }

        private static int WhatAction()
        {
            string userInput = "";

            while (true)
            {
                Console.WriteLine("What will it do...");
                Console.WriteLine("get (n)ame, say (g)reeting, go to (s)leep, (w)ake up, or (e)at a taco?");

                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "n":
                        return 1;
                    case "g":
                        return 2;
                    case "s":
                        return 3;
                    case "w":
                        return 4;
                    default:
                        Console.WriteLine("\nThat isn't a valid selection! Try again.");
                        break;
                };
            }

        }
    }
}

