using System;

namespace RefReturn
{
    class Product
    {
        private int price = 100;

        public ref int GetPrice()
        {
            return ref price;
        }

        public void printPrice()
        {
            Console.WriteLine("Price: " + price);
        }
    }
    internal class MainApp
    {
        static void Main(string[] args)
        {
            Product carrot = new Product();
            ref int ref_local_price = ref carrot.GetPrice();
            int normal_local_price = carrot.GetPrice();

            carrot.printPrice();
            Console.WriteLine("Ref Local Price: " + ref_local_price);
            Console.WriteLine("Normal Local Price: " + normal_local_price);

            ref_local_price = 200;

            carrot.printPrice();
            Console.WriteLine("Ref Local Price: " + ref_local_price);
            Console.WriteLine("Normal Local Price: " + normal_local_price);
        }
    }
}
