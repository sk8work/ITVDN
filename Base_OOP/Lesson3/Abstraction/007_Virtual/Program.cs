using System;

// Приведение к базовому тиау

namespace _007_Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();

            // Upcast
            BaseClass instanceUp = instance;
            instanceUp.Method();

            // Downcast
            DerivedClass instanceDown = (DerivedClass)instanceUp;
            instanceDown.Method();

            // Delay
            Console.ReadKey();
        }
    }
}
