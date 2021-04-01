using System;

// Interfaces

namespace _001_Interfaces
{
    interface IInterface
    {
        void Method();
    }

    class MyClass : IInterface
    {
        public void Method()
        {
            Console.WriteLine("Method - Interface realization");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();

            my.Method();

            // Delay
            Console.ReadKey();
        }
    }
}
