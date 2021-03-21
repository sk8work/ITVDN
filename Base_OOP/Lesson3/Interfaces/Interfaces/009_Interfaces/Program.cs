using System;

// Наследование абстрактных классов от интерфейсов

namespace _009_Interfaces
{

    interface Interfase
    {
        void Method();
    }

    abstract class AbstractClass : Interfase
    {
        // Замещение абстрактного метода из интерфейса в абстрактном классе
        public abstract void Method();
    }

    class ConcreteClass : AbstractClass
    {
        // Реализация абстрактного метода из абстрактного класса
        // в кнкретном месте обязательна.
        public override void Method()
        {
            Console.WriteLine("Метод - реализация интерфейса в абстрактном классе");
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
