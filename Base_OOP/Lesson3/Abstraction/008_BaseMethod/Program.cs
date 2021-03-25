using System;

namespace _008_BaseMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();

            // Delay
            Console.ReadKey();
        }
    }
}
