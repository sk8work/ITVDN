using System;

// Наследование абстрактных классов от интерфейса

namespace _008_Interfaces
{
    interface Interface
    {
        void Method();
    }

    abstract class AbstractClass : Interface
    {
        // Реализация абстрактного метода из интерфейса
        // в абстрактном классе НЕ обязательна
        public void Method()
        {
            Console.WriteLine("Метод - реализация в абстрактном классе.");
        }
    }

    class ConcreteClass : AbstractClass
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass instance = new ConcreteClass();
            instance.Method();

            // Delay
            Console.ReadKey();
        }
    }
}
