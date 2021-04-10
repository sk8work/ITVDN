using System;

// Статические члены в нестатических классах

namespace _004_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            NotStaticClass.Property = 33;
            Console.WriteLine(NotStaticClass.Property);

            // Delay
            Console.ReadKey();
        }
    }
}
