using System;

// Абстрактный класс может быть унаследован от конкретнго класса.

namespace _002_Abstraction
{
    // Конкретный класс А.
    class ConcreteClassA
    {
        public void Operation()
        {
            Console.WriteLine("ConcreteClassA.Operation");
        }
    }

    // Абстрактный класс
    abstract class AbstractClass : ConcreteClassA
    {
        public abstract void Method();
    }

    // Конкретный класс В.
    class ConcreteClassB : AbstractClass
    {
        public override void Method()
        {
            Console.WriteLine("ConcreteClassB.Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass instance = new ConcreteClassB();

            instance.Method();
            instance.Operation();

            // Delay
            Console.ReadKey();
        }
    }
}
