using System;

namespace Overriding
{
    class ArmorSuit
    {
        public virtual void Initialize()
        {
            Console.WriteLine("Armored");
        }
    }

    class IronMan : ArmorSuit 
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Repulsor Rays Armed");
        }
    }

    class WarMachine : ArmorSuit
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Double-Barrel Cannons Armed");
            Console.WriteLine("Machine Gun Armed");
        }
    }

        internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating ArmorSuit...");
            ArmorSuit armorsuit = new ArmorSuit();
            armorsuit.Initialize();

            Console.WriteLine("\nCreating IronMan...");
            ArmorSuit ironman = new IronMan();
            ironman.Initialize();

            Console.WriteLine("\nCreating WarMachine...");
            ArmorSuit warmachine = new WarMachine();
            warmachine.Initialize();
        }
    }
}
