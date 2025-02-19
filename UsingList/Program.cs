using System;
using System.Collections;

namespace UsingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }
            foreach (object i in list)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            list.RemoveAt(2);

            foreach (int i in list)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            list.Insert(2, 2);

            foreach (object i in list)
            {
                Console.Write($"{i} ");
            }

            list.Add("abc");
            list.Add("def");

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }
            Console.WriteLine();

        }
    }
}
