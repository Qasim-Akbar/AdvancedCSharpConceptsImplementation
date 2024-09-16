using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpConceptsImplementation
{
    internal abstract class Device
    {
        public string Name { get; set; }
        public bool IsOn { get; private set; }

        public Device(string name)
        {
            Name = name;
            IsOn = false;
        }

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Name} is turned on.");
        }

        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Name} is turned off.");
        }

        public abstract void Operate(); // Abstract method to be implemented by subclasses
    }
}
