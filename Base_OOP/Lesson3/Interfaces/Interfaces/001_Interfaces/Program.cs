using System;

// Интерфейсы

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
            Console.WriteLine("Метод - реализация Интерфейса");
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
