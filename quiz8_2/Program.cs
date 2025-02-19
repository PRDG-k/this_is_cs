using System;

namespace quiz8_2
{
    interface IFlyable
    {
        void Fly();
    }
    interface IRunnable
    {
        void Run();
    }
    class Plane : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Plane is flying");
        }
    }
    class Car : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("Car is running");
        }
    }
    class FlyingCar : IFlyable, IRunnable
    {
        Car car = new Car();
        Plane plane = new Plane();
        public void Fly()
        {
            plane.Fly();
        }
        public void Run()
        {
            car.Run();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FlyingCar flyingCar = new FlyingCar();
            flyingCar.Fly();
            flyingCar.Run();

            IRunnable runnable = new FlyingCar();
            IFlyable flyable = new FlyingCar();

            runnable.Run();
            flyable.Fly();
        }
    }
}
