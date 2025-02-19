using System;

namespace CopyingArray
{
    public struct Data {
        public int crushId;
        public int count;
        public Data(int crushId = -1, int count = 0)
        {
            this.crushId = crushId;
            this.count = count;
        }
    }
    
    internal class Program
    {
        static void CopyArray<T>(T[] source, T[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }

        static void Main(string[] args)
        {
            int[] source = {1, 2, 3, 4, 5 };
            int[] target = new int[source.Length];

            CopyArray<int>(source, target);

            foreach (int element in target)
            {
                Console.WriteLine(element);
            }

            string[] source2 = { "one", "two", "three", "four", "five" };
            string[] target2 = new string[source2.Length];

            CopyArray<string>(source2, target2);

            foreach (string element in target2)
            {
                Console.WriteLine(element);
            }

            Data data = new Data();
            Console.WriteLine(data.crushId);
            Console.WriteLine(data.count);
        }
    }
}
