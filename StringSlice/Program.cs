using System;
using static System.Console;

namespace StringSlice
{
    class MaipApp
    {
        static void Main(string[] args)
        {
            string greeting = "Good morning";

            WriteLine(greeting[..5]);
            WriteLine(greeting[5..]);
            WriteLine();

            string[] arr = greeting.Split(
                new string[] {" "}, StringSplitOptions.None);
            WriteLine("Word Count: {0}", arr.Length);

            foreach (string item in arr)
            {
                WriteLine(item);
            }



        }
    }
}