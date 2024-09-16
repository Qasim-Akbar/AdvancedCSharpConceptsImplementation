using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpConceptsImplementation
{
    internal class TemperatureSensor
    {
        public delegate void TempratureThresholdExceededEventHandler(object sender, EventArgs e);
        public event TempratureThresholdExceededEventHandler TempratureThresholdExceeded;

        private int _temperature;

        public void SetTemprature(int temperature)
        {
            _temperature = temperature;
            if(_temperature > 30)
            {
                OnTempratureThresholdExceeded();
            }
        }

        protected virtual void OnTempratureThresholdExceeded()
        {
            TempratureThresholdExceeded?.Invoke(this, EventArgs.Empty);
        }
    }
}
