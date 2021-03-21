using System;

// Множественное наследование

namespace _002_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Interface1 instance1 = new DerivedClass();
            Interface2 instance2 = new DerivedClass();

            instance1.Method1();

            instance2.Method2();

            // Delay
            Console.ReadKey();
        }
    }
}
