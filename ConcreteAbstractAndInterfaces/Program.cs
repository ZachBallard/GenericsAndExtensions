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
            string food = "taco";

            var panda = new Panda("Dentalfloss the Panda");
            var human = new Human("Steve the Human");
            var robot = new Robot("Eternal the Sad Robot");

            int objectSelected = 0;
            int whichAction = 0;

            bool willKeepOn = true;
            
            //These lists are purely demonstrative via errors
            List<Human> humanList = new List<Human>();
            humanList.Add(human);
            List<Robot> robotList = new List<Robot>();
            robotList.Add(robot);
            List<Panda> pandaList = new List<Panda>();
            pandaList.Add(panda);
            List<INotARobot> notRobotList = new List<INotARobot>();
            notRobotList.Add(human);
            notRobotList.Add(panda);

            Console.WriteLine("Welcome to a really strange room containing a Human, a Robot, and a Panda!");

            while (true)
            {
                objectSelected = Select();

                whichAction = WhatAction();

                if (objectSelected == 1)
                {
                    switch (whichAction)
                    {
                        case 1:
                            human.DisplayName();
                            break;
                        case 2:
                            human.DisplayGreeting();
                            break;
                        case 3:
                            human.GoToSleep();
                            break;
                        case 4:
                            human.WakeUp();
                            break;
                        case 5:
                            human.Eat(food);
                            break;
                    }
                }
                else if (objectSelected == 2)
                {
                    switch (whichAction)
                    {
                        case 1:
                            robot.DisplayName();
                            break;
                        case 2:
                            robot.DisplayGreeting();
                            break;
                        case 3:
                            robot.ShutDown();
                            break;
                        case 4:
                            robot.StartUp();
                            break;
                        case 5:
                            robot.Eat(food);
                            break;
                    }
                }
                else
                {
                    switch (whichAction)
                    {
                        case 1:
                            panda.DisplayName();
                            break;
                        case 2:
                            panda.DisplayGreeting();
                            break;
                        case 3:
                            panda.GoToSleep();
                            break;
                        case 4:
                            panda.WakeUp();
                            break;
                        case 5:
                            panda.Eat(food);
                            break;
                    }
                }

                willKeepOn = willMoreStuff();
                if (!willKeepOn)
                {
                    break;
                }
            }
        }

        private static bool willMoreStuff()
        {
            string userInput = "";

            while (true)
            {
                Console.WriteLine("\nDo you want to keep screwing with the pointless beings lives?");
                Console.WriteLine("(y)es, I really enjoy it / (n)o, and probably never again");

                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "y":
                        return true;
                    case "n":
                        return false;
                    default:
                        Console.WriteLine("\nThat isn't a valid selection! Try again.");
                        break;
                };
            }
        }

        private static int Select()
        {
            string userInput = "";

            while (true)
            {
                Console.WriteLine("\nYou can make them do some stuff. Would you like to mess with...");
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
                Console.WriteLine("\nWhat will it do...");
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
                    case "e":
                        return 5;
                    default:
                        Console.WriteLine("\nThat isn't a valid selection! Try again.");
                        break;
                };
            }

        }
    }
}

