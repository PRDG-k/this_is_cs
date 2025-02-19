namespace ex7_2
{
    class A { }
    class B : A { }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            A c = new B();
            B d = (B)new A();
            B? e = new A() as B;
        }
    }
}
