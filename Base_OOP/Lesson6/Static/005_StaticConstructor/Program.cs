using System;

// Static construtor

namespace _005_StaticConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NotStaticClass.ReadonlyField);

            // Delay
            Console.ReadKey();
        }
    }
}
