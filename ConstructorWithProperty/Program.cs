using System;

namespace ConstructorWithProperty
{
    class BirthdayInfo
    {
        public string Name { get; set; } = "Unknown";
        public DateTime Birthday { get; set; }
        public int Age
        {
            get
            {
                return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo birthday = new BirthdayInfo()
            {
                Name = "서현",
                Birthday = new DateTime(1991, 6, 28)
            };
            Console.WriteLine($"Name : {birthday.Name}");
            Console.WriteLine($"Birthday : {birthday.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birthday.Age}");

        }
    }
}
