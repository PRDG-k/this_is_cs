using System;
using System.Collections;

namespace Ex10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[,] arrayA = new int[2, 2] { { 3, 2 }, { 1, 4 } };
            int[,] arrayB = new int[2, 2] { { 9, 2 }, { 1, 7 } };
            int[,] matrix = new int[2, 2] { { 0, 0 }, { 0, 0 } };

            for (int i = 0; i < arrayA.GetLength(0); i++)
            {
                for (int j = 0; j < arrayB.GetLength(1); j++)
                {
                    for (int k = 0; k < arrayA.GetLength(1); k++)
                    {
                        matrix[i, j] += arrayA[i, k] * arrayB[k, j];
                    }
                }
            }
            foreach (var item in matrix)
            {
                Console.WriteLine(item);
            }
        }
    }
}
