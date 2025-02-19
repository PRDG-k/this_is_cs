using System;
using System.Collections;

namespace Indexer
{
    class MyList
    {
        private int[] array;
        public MyList()
        {
            array = new int[3];
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }

                array[index] = value;
            }
        }
        public int Length // Length 속성 구현(array가 private니까)
        {
            get { return array.Length; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            int newSize = list.Length + 1;
            for (int i = 0; i < newSize; i++)
            {
                list[i] = i;
            }


            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
