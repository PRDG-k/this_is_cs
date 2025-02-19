using System;
using System.Collections.Generic;

namespace Exercise1
{
    internal class Program
    {
        class Fibonacci
        {
            private static Dictionary<long, long> memo = new Dictionary<long, long>();

            public static long GetNumber(long index)
            {
                if (memo.ContainsKey(index))
                {
                    return memo[index];
                }

                long result = index switch
                {
                    0 => 0,
                    1 => 1,
                    _ => GetNumber(index - 2) + GetNumber(index - 1)
                };

                memo[index] = result;
                Console.WriteLine(result);
                return result;
            }
        }

        static void Main(string[] args)
        {
            //for (int i = 0; i < 5; i++) {
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Exercise p.196-01");
            //for (int i = 0; i < 5; i++) {
            //    Console.WriteLine(new string('*', i + 1));
            //}

            //Console.WriteLine("\nExercise p.196-02");
            //for (int i = 5; i > 0; i--)
            //{
            //    Console.WriteLine(new string('*', i));
            //}

            //Console.WriteLine("\nExercise p.196-03");
            //int number = 5;
            //while (number > 0)
            //{
            //    Console.WriteLine(new string('*', number--));
            //}

            //number = 0;
            //do {
            //    Console.WriteLine(new string('*', ++number));
            //} while (number < 5);

            //Console.WriteLine("\nExercise p.196-04");

            //int count;
            //Console.WriteLine("Enter a number: ");
            //while (true)
            //{
            //    #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            //    string input = Console.ReadLine();
            //    #pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            //    if (int.TryParse(input, out count) && count > 0)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter a positive integer: ");
            //    }
            //}
            //number = 0;
            //do
            //{
            //    Console.WriteLine(new string('*', ++number));
            //} while (number < count);


            Console.WriteLine("\nExercise p.196-05");
            Console.WriteLine("Enter a number: ");
            int count2;
            while (true)
            {
                #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                string input = Console.ReadLine();
                #pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                if (int.TryParse(input, out count2) && count2 > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer: ");
                }
            }
            Console.WriteLine(Fibonacci.GetNumber(count2));
        }
    }
}
