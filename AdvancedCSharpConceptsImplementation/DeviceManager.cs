using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpConceptsImplementation
{
    internal class DeviceManager
    {
        private List<Device> _devices = new List<Device>();

        public void AddDevice(Device device)
        {
            _devices.Add(device);
        }

        public void DisplayOnDevices()
        {
            var onDevices = _devices.Where(x => x.IsOn).ToList();
            onDevices.ForEach(x => Console.WriteLine($"{x.Name} is ON."));
        }
    }
}
