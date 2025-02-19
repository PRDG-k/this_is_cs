using System;
using Extenstion;

namespace Extenstion
{
    public static class StringExtension
    {
        public static string Append(this string str, string appendStr)
        {
            return str + appendStr;
        }
    }
}

namespace quiz7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            string result = hello.Append(world);
            Console.WriteLine(result);
        }
    }
}
