using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpConceptsImplementation.Models
{
    internal class Light : Device
    {
        public int Brightness { get; set; }

        public Light(string name, int brightness) : base(name) 
        {
            Brightness = brightness;
        }

        public override void Operate()
        {
            Console.WriteLine($"{Name} is now operating with brightness {Brightness}.");
        }
    }
}
