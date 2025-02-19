using System;

namespace Ex6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            Plus(a, b, out int resultA);

            Console.WriteLine($"{a} + {b} = {resultA}");

            double x = 2.4;
            double y = 3.1;
            Plus(x, y, out double resultB);
            Console.WriteLine($"{x} + {y} = {resultB}");
        }

        public static void Plus(int a, int b, out int result)
        {
            result = a + b;
        }

        public static void Plus(double a, double b, out double result)
        {
            result = a + b;
        }
    }
}
