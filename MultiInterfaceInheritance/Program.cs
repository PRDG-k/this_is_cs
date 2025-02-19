using System;

namespace MultiInterfaceInheritance
{
    interface IRunnable
    {
        void Run();
    }
    interface IFlyable
    {
        void Fly();
    }

    class FlyingCar : IRunnable, IFlyable
    {
        public void Run()
        {
            Console.WriteLine("Run");
        }
        public void Fly()
        {
            Console.WriteLine("Fly");
        }
    }
    internal class MainApp
    {
        static void Main(string[] args)
        {
            FlyingCar flyingcar = new FlyingCar();
            flyingcar.Run();
            flyingcar.Fly();

            IRunnable runnable = flyingcar as IRunnable;
            runnable.Run();

            IFlyable flyable = flyingcar as IFlyable;
            flyable.Fly();
        }
    }
}
