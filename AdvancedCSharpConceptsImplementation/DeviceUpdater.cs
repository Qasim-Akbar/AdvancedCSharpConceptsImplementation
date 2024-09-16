using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharpConceptsImplementation
{
    internal class DeviceUpdater
    {
        public async Task UpdateDeviceAsync(Device device)
        {
            Console.WriteLine($"Updating {device.Name}...");
            await Task.Delay(30000); // Simulate a long-running update task
            Console.WriteLine($"{device.Name} update completed.");
        }
    }
}
