using System;
using MonoBrickFirmware.Display.Dialogs;
using MonoBrickFirmware.Movement;
using System.Threading;
using MonoBrickFirmware.Display;
using MonoBrickUtils;
using MonoBrickFirmware.Sensors;

namespace Robot1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (var i = 0; i < 1000; i++)
            {
                var sensor = new EV3IRSensor(SensorPort.In4);
                Ev3Console.WriteLine($"IR: {sensor.ReadDistance()}");
            }
            Thread.Sleep(10000);
        }
    }
}