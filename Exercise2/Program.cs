using System;

namespace Exercise2
{
    internal class Program
    {
        static double Square(double x)
        {
            return x * x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            string input = Console.ReadLine();
            double arg = Convert.ToDouble(input);

            Console.WriteLine("Result: " + Square(arg));
        }
    }
}
