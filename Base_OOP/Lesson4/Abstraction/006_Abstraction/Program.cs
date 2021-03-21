using System;

namespace _006_Abstraction
{
    abstract class AbstractClass
    {
        // Конструктор (отрабатывает первым)
        public AbstractClass()
        {
            Console.WriteLine("1 AbstractClass()");

            // Вызывается реализация метода из производного класса - ConcreteClass
            this.AbstractMethod();

            Console.WriteLine("2 AbstractClass()");
        }

        public abstract void AbstractMethod();
    }

    class ConcreteClass : AbstractClass
    {
        string s = "First";

        // конструктор (отрабатывает вторым)
        public ConcreteClass()
        {
            Console.WriteLine("3 ConcreteClass()");
            s = "Second";
        }

        public override void AbstractMethod()
        {
            Console.WriteLine("Реализация метода AbstractMethod() в ConcreteClass {0}", s);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass insance = new ConcreteClass();

            Console.WriteLine(new string('-', 50));

            insance.AbstractMethod();

            // Delay
            Console.ReadKey();
        }
    }
}
