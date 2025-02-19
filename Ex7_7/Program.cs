using System;

namespace Ex7_7
{
    internal class Program
    {
        private static double GetDiscountRate(object client)
        {
            switch (client)
            {
                case ("student", int n) when n < 18:
                    return 0.2;
                case ("student", _):
                    return 0.1;
                case ("Member", int n) when n < 18:
                    return 0.1;
                case ("Member", _):
                    return 0.05;
                default:
                    return 0;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetDiscountRate(("student", 17)));
        }
    }
}
