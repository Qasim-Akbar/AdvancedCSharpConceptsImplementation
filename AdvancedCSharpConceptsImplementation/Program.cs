
using AdvancedCSharpConceptsImplementation;
using AdvancedCSharpConceptsImplementation.Models;

namespace AdvancedCSharpConceptsImplementation
{
    class Program
    {
        static async Task Main(string[] args)
        {
            DeviceManager deviceManager = new DeviceManager();

            Fan fanA = new Fan("Fan A", 5);
            Fan fanB = new Fan("Fan B", 6);

            Light lightA = new Light("Light A", 23);
            Light lightB = new Light("Light B", 24);
            lightB.TurnOn();

            deviceManager.AddDevice(fanA);
            deviceManager.AddDevice(fanB);
            deviceManager.AddDevice(lightA);
            deviceManager.AddDevice(lightB);

            DeviceUpdater updater = new DeviceUpdater();
          //  await updater.UpdateDeviceAsync(fanB); 
            updater.UpdateDeviceAsync(fanB);

            TemperatureSensor temperatureSensor = new TemperatureSensor();
            temperatureSensor.TempratureThresholdExceeded += fanA.SensorListenor;
            temperatureSensor.TempratureThresholdExceeded += fanB.SensorListenor;

            string valu = null;
            try
            {
                testIT(valu);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            temperatureSensor.SetTemprature(31);

            deviceManager.DisplayOnDevices();

            fanA.Operate();

            Console.ReadLine();
            

            temperatureSensor.TempratureThresholdExceeded -= fanA.SensorListenor;
            temperatureSensor.TempratureThresholdExceeded -= fanB.SensorListenor;
        }

        private static void testIT(string valu)
        {
            ArgumentNullException.ThrowIfNull(valu);
            Console.WriteLine($"valU: {valu}");
        }
    }
}
