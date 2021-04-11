using System;

// Статические члены не могут быть виртуальными, переопределенными и абстрактными

// Статические члены поддерживают замещение

namespace _009_Static
{
    abstract class BaseClass
    {
        /*public static virtual void StaticMethod()
        {
            Console.WriteLine("BaseClass.StaticMethod");
        }*/

        public static void StaticMethod()
        {
            Console.WriteLine("BaseClass.StaticMethod");
        }
    }

    class DerivedClass : BaseClass
    {
        /*public static override void StaticMethod()
        {
            Console.WriteLine("DerivedClass.StaticMethod");
        }*/

        public static new void StaticMethod()
        {
            Console.WriteLine("DerivedClass.StaticMethod");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass.StaticMethod();
            DerivedClass.StaticMethod();

            // Delay
            Console.ReadKey();
        }
    }
}
