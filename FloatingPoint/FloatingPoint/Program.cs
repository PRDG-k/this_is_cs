using System;

namespace FloatingPoint
{
    class MainApp
    {
        static void Main(string[] args)
        {
            float a = float.MaxValue;
            Console.WriteLine(a);

            double b = a + a / 10000;
            Console.WriteLine(b);
            // 계산 후 할당이기 때문에 오버플로우로 b는 무한대가 된다.
        }
    }
}