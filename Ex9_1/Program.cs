using System;

namespace Ex9_1
{
    class NameCard
    {
        public required int Age { get; set; }
        public required string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            NameCard myCard = new NameCard { Age = 24, Name = "상현" };
            Console.WriteLine("나이: {0}", myCard.Age);
            Console.WriteLine("이름: {0}", myCard.Name);
        }
    }
}
