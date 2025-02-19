using System;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jarray = new int[3][];
            jarray[0] = new int[] { 1, 2, 3, 4 };
            jarray[1] = new int[] { 5, 6, 7, 8, 9 };
            jarray[2] = new int[] { 10, 11, 12, 13, 14, 15 };

            foreach (int[] arr in jarray)
            {
                foreach(int i in arr)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
