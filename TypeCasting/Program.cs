using System;

namespace TypeCasting
{
    class Mammal
    {
        public void Nurse()
        {
            Console.WriteLine("Mammal nursing");
        }
    }
    class Dog : Mammal 
    {
        public void Bark()
        {
            Console.WriteLine("Dog barking");
        }
    }

    class Cat: Mammal
    {
        public void Meow()
        {
            Console.WriteLine("Cat meowing");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Mammal mammal = new Dog();
            Dog dog;

            if (mammal is Dog)
            {
                dog = (Dog)mammal;
                dog.Bark();
            }

            Mammal mammal2 = new Cat();
            Cat cat = mammal2 as Cat;

            if (cat != null)
            {
                cat.Meow();
            }
            
            Cat cat2 = mammal as Cat;
            if (cat2 != null)
            {
                cat2.Meow();
            }
            else
            {
                Console.WriteLine("cat2 is not a Cat");
            }
        }
    }
}
