﻿using System;
using System.Collections;

namespace Yield
{
    class MyEnumerator
    {
        int[] numbers = { 1, 2, 3, 4 };
        public IEnumerator GetEnumerator()
        {
            //yield return numbers[0];
            //yield return numbers[1];
            //yield return numbers[2];
            //yield break;
            //yield return numbers[3];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 2) { yield break; }
                yield return numbers[i];
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var obj = new MyEnumerator();
            foreach (int i in obj)
            {
                Console.WriteLine(i);
            }
        }
    }
}
