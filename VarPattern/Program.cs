using System;

namespace VarPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var IsPassed =
                (int[] scores) => scores.Sum() / scores.Length is var average
                && average >= 60
                && Array.TrueForAll(scores, score => score >= 60);

            int[] scores1 = { 60, 70, 80, 90 };
            int[] scores2 = { 60, 70, 80, 50 };

            Console.WriteLine(IsPassed(scores1)); // True
            Console.WriteLine(IsPassed(scores2)); // False
        }
    }
}
