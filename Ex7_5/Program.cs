using System;

namespace Ex7_5
{
    struct ACSetting
    {
        public double currentInCelsius;
        public double target;

        public double GetTarget()
        {
            return target;
        }

        public readonly double GetFahrenheit()
        {
            //target = currentInCelsius * 9 / 5 + 32;
            return currentInCelsius * 9 / 5 + 32;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ACSetting acs;
            acs.currentInCelsius = 25;
            acs.target = 25;

            Console.WriteLine($"{acs.GetFahrenheit()}");
            Console.WriteLine($"{acs.target}");
        }
    }
}
