using System;
using System.Collections;

namespace Ex10_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["회사"] = "Mircrosoft";
            ht["URL"] = "www.microsoft.com";

            Console.WriteLine($"회사 : {ht["회사"]}");
            Console.WriteLine($"URL : {ht["URL"]}");

        }
    }
}
