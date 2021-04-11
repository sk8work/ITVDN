using System;

// Статические члены в абстрактных классах

namespace _008_AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass instance = AbstractClass.CreateObject();
            instance.Method();

            // Delay
            Console.ReadKey();
        }
    }
}
