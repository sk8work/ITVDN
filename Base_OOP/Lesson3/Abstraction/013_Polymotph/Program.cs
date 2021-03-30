using System;

namespace _013_Polymotph
{
    class BaseClass { }

    class Derived1 : BaseClass { }

    class Derived2 : BaseClass { }

    class Container
    {
        public BaseClass field;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Container container = new Container();

            container.field = new Derived1();
            Console.WriteLine(container.field.GetHashCode());

            container.field = new Derived2();
            Console.WriteLine(container.field.GetHashCode());

            // Delay
            Console.ReadKey();
        }
    }
}
