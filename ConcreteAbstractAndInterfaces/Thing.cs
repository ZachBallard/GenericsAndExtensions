using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteAbstractAndInterfaces
{
    public abstract class Thing
    {
        public string Name { get; set; }
        public bool IsAsleep { get; set; }

        public abstract void Eat(string food);
        public abstract void DisplayName();
        public abstract void DisplayGreeting();
    }

    interface INotARobot
    {
        
    }
}
