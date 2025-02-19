using System;
namespace InitOnly
{
    class Transaction
    {
        public required string From { get; init; }
        public required string To { get; init; }
        public int Amount
        {
            get; init;
        }
        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : {Amount,5}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Transaction t1 = new Transaction { From = "Alice", To = "Bob", Amount = 100 };
            Transaction t2 = new Transaction { From = "Bob", To = "Alice", Amount = 50 };
            Transaction t3 = new Transaction { From = "Charlie", To = "Bob", Amount = 25 };

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
        }
    }
}
