using System;

namespace Inheritance
{
    class Base
    {
        protected string Name;
        public Base(string Name)
        {
            this.Name = Name;
            Console.WriteLine("Base Constructor {0}", this.Name);
        }
        ~Base()
        {
            Console.WriteLine("Base Destructor {0}", this.Name);
        }
        public void BaseMethod()
        {
            Console.WriteLine("Base Method {0}", this.Name);
        }
    }
    class Derived : Base 
    { 
        public Derived(string Name) : base(Name)
        {
            Console.WriteLine("Derived Constructor {0}", this.Name);
        }

        ~Derived()
        {
            Console.WriteLine("Derived Destructor {0}", this.Name);
        }

        public void DerivedMethod()
        {
            Console.WriteLine("Derived Method {0}", this.Name);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Base a = new Base("SAS");
            a.BaseMethod();

            Derived b = new Derived("PLTR");
            b.BaseMethod();
            b.DerivedMethod();
        }
    }
}
