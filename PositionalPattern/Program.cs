using System;

namespace PositionalPattern
{
    struct Audience
    {
        public bool IsCitizen { get; init; }
        public int Age { get; init; }
        public Audience(bool isCitizen, int age)
        {
            IsCitizen = isCitizen;
            Age = age;
        }

        public void Deconstruct(out bool isCitizen, out int age)
        {
            isCitizen = IsCitizen;
            age = Age;
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            var CalculateFee = (Audience audience) => audience switch
            {
                (true, < 19) => 100,
                (true, _) => 210,
                (false, < 19) => 200,
                (false, _) => 400,
            };

            var a1 = new Audience(true, 10);
            var a2 = new Audience(false, 33);
        }
    }
}