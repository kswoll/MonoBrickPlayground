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
//            ReadFromEV3IRSensor();
//            ReadFromHiTechnicCompassSensor();
//            ReadFromHiTechnicTiltSensor();
//            ReadFromNXTSoundSensor();
            ReadFromEV3TouchSensor();
            Thread.Sleep(10000);
        }

        static void ReadFromEV3IRSensor()
        {
            for (var i = 0; i < 1000; i++)
            {
                var sensor = new EV3IRSensor(SensorPort.In4);
                var distance = sensor.ReadDistance();
                Ev3Console.WriteLine($"IR: {distance}");
                Thread.Sleep(10);
            }
        }

        static void ReadFromHiTechnicCompassSensor()
        {
            for (var i = 0; i < 1000; i++)
            {
                var sensor = new HiTecCompassSensor(SensorPort.In4);
                var heading = sensor.ReadDirection();
                Ev3Console.WriteLine($"IR: {heading}");
                Thread.Sleep(10);
            }
        }

        static void ReadFromHiTechnicTiltSensor()
        {
            for (var i = 0; i < 1000; i++)
            {
                var sensor = new HiTecTiltSensor(SensorPort.In4);
                var position = sensor.ReadPosition();
                Ev3Console.WriteLine($"IR: {position.X}/{position.Y}/{position.Z}");
                Thread.Sleep(10);
            }
        }

        static void ReadFromNXTSoundSensor()
        {
            for (var i = 0; i < 1000; i++)
            {
                var sensor = new NXTSoundSensor(SensorPort.In4);
                var value = sensor.ReadAsString();
                Ev3Console.WriteLine($"IR: {value}");
                Thread.Sleep(10);
            }
        }

        static void ReadFromNXTTouchSensor()
        {
            for (var i = 0; i < 1000; i++)
            {
                var sensor = new NXTTouchSensor(SensorPort.In4);
                var value = sensor.ReadAsString();
                Ev3Console.WriteLine($"IR: {value}");
                Thread.Sleep(10);
            }
        }

        static void ReadFromEV3TouchSensor()
        {
            for (var i = 0; i < 1000; i++)
            {
                var sensor = new EV3TouchSensor(SensorPort.In4);
                var value = sensor.ReadAsString();
                Ev3Console.WriteLine($"IR: {value}");
                Thread.Sleep(10);
            }
        }
    }
}