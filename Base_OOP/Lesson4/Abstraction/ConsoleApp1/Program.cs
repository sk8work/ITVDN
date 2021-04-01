using System;

// Abstract class

namespace _001_Abstraction
{
   // Abstract class
   abstract class AbstractClass
    {
        public abstract void Method();
    }

    // Concrete class
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
