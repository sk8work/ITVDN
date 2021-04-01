using System;

// Насделование абстрактных классов от нитерфейсов

namespace _008_Interfaces
{
    interface IInterface
    {
        void Method();
    }

    abstract class AbstractClass : IInterface
    {
        // Реализация абстрактного метода из интерфейса в абстрактном классе НЕ ОБЯЗАТЕЛЬНА
        public void Method()
        {
            Console.WriteLine("Method - реализация интерфейса в абстрактном классе");
        }
    }

    class ConcreteClass : AbstractClass
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConcreteClass instance = new ConcreteClass();
            instance.Method();

            // Delay
            Console.ReadKey();

        }
    }
}
