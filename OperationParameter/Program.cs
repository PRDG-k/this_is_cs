using System;

namespace OperationParameter
{
    internal class MainApp
    {
        static void PrintProfile(string name, string phone = "")
        {
            Console.WriteLine($"Name: {name}, Phone: {phone}");
        }
        static void Main(string[] args)
        {
            PrintProfile("medium");
            PrintProfile("gwansu", "123-456-7890");
            PrintProfile(name: "bongil", phone: "123-456-7890");
        }
    }
}
