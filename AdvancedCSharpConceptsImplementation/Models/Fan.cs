using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpConceptsImplementation.Models
{
    internal class Fan : Device
    {
        public int Speed { get; set; }

        public Fan(string name, int speed) : base(name)
        {
            Speed = speed;
        }

        public void SensorListenor(object sender, EventArgs e)
        {
            Console.WriteLine($"{Name} turned on due to high temperature.");
            TurnOn();
        }

        public override void Operate()
        {
            Console.WriteLine($"{Name} is operating at speed {Speed}");
        }
    }
}
