using System;

namespace Slice
{
    internal class Program
    {
        static void PrintArray(System.Array array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            char[] array = new char['Z' - 'A' + 1]; // 알파벳 개수만큼 배열 생성
            for (int i  = 0;  i < array.Length;  i++)
            {
                array[i] = (char)('A' + i);
            }
            PrintArray(array[..]);
            PrintArray(array[5..]);

            PrintArray(array[5..10]);

            Index last = ^0;
            Range range = 5..last;
            PrintArray(array[range]);

            PrintArray(array[^4..^1]);
        }
    }
}
