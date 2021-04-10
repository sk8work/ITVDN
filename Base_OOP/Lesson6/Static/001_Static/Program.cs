using System;

// Static members from nonstatic classes

namespace _001_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            NonStaticClass instance1 = new NonStaticClass(1);
            NonStaticClass instance2 = new NonStaticClass(2);

            instance1.Method();
            instance2.Method();

            NonStaticClass.field = 1;

            instance1.Method();
            instance2.Method();

            // Delay
            Console.ReadKey();
        }
    }
}
