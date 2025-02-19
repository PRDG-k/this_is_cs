using System;

namespace MethodHiding
{
    class Base
    {
        public void MyMethod()
        {
            Console.WriteLine("Base Method");
        }
    }
    class Derived : Base
    {
        public new void MyMethod()
        {
            Console.WriteLine("Derived Method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Base baseobj = new Base();
            baseobj.MyMethod();

            Derived derivedobj = new Derived();
            derivedobj.MyMethod();

            Base baseOrDerived = new Derived();
            baseOrDerived.MyMethod();
        }
    }
}
