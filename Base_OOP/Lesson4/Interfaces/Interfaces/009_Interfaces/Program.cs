using System;

// Наследование абстрактных классов от интерфейсов

namespace _009_Interfaces
{
    interface IInterface
    {
        void Method();
    }

    abstract class AbstractClass : IInterface
    {
        // Замещение абстрактного метода из интерфейса в абстрактном класе
        public abstract void Method();
    }

    class ConcreteClass : AbstractClass
    {
        // Реализация фбстрактного метода из абстрактного класса в конкретном классе обязательна
        public override void Method()
        {
            Console.WriteLine("Method - реализация интерфейса в абстрактном классе");
        }
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
