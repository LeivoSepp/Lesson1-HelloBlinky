using Windows.ApplicationModel.Background;
using Windows.Devices.Gpio;
using System.Threading.Tasks;

namespace HelloBlinky
{
    public sealed class StartupTask : IBackgroundTask
    {
        public void Run(IBackgroundTaskInstance taskInstance)
        {
            int LED_PIN = 35;
            var gpio = GpioController.GetDefault();
             
            GpioPin pin = gpio.OpenPin(LED_PIN);
            pin.SetDriveMode(GpioPinDriveMode.Output);

            while(true)
            {
                pin.Write(GpioPinValue.Low);
                Task.Delay(1000).Wait();
                pin.Write(GpioPinValue.High);
                Task.Delay(1000).Wait();
            }
        }
    }
}
