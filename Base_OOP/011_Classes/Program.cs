using System;

// Создание экземпляра по слабой ссылке. (Анонимные объекты)

namespace Classes
{
    class MyClass
    {
        public void Method()
        {
            Console.WriteLine("Hello world!");
        }
    }
     
    class Program
    {
        static void Main(string[] args)
        {
            new MyClass().Method();

            // Delay
            Console.ReadKey();
        }
    }
}
