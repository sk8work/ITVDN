using System;

// Абстрактный класс

namespace _001_Abstraction
{
    // Абстрактный класс.
    abstract class AbstractClass
    {
        public abstract void Method(); // у абстрактных методов нет тела
        //public virtual void Method() { }; // на самом деле у нас так!!
    }

    // Конкретный класс
    class ConcreteClass : AbstractClass
    {
        public override void Method()
        {
            Console.WriteLine("Implementation");
        }
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
