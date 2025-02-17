using System;

namespace While
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int i = 10;

            while(i > 0)
            {
                Console.WriteLine($"i: {i--}");
            }

            do
            {
                Console.WriteLine($"i: {i++}");
            } while (i < 10);
        }
    }
}
