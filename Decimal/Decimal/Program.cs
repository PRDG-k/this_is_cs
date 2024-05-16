using System;

namespace Decimal
{
    class MainApp
    {
        static void Main(string[] args)
        {
            float a = 3.1234_5678_1234_5678_1234_5678_1234_5678_12f;
            double b = 3.1234_5678_1234_5678_1234_5678_1234_5678_12f;
            decimal c = 3.1234_5678_1234_5678_1234_5678_1234_5678_12m;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}