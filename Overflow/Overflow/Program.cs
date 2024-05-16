using System;

namespace Overflow
{
    class MainApp
    {
        static void Main(string[] args)
        {
            uint a = uint.MaxValue;
            int b = int.MaxValue;

            Console.WriteLine(a);

            a = a + 1;

            Console.WriteLine(a);

            Console.WriteLine(b);

            b = b + 1;

            Console.WriteLine(b);
        }
    }
}