using System;
using BlinkStickDotNet;

namespace BlinkStickConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test BlinkStick device");

            var led = BlinkStick.FindFirst();

            led.OpenDevice();
            led.Blink(RgbColor.FromString("green"), 3);
            led.SetColor(RgbColor.FromString("red"));

            Console.WriteLine("Press a key to quit program");
            Console.ReadLine();

            led.TurnOff();
        }
    }
}
