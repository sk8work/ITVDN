using System;

// Частичные классы (Partial classes)

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            PartialClass instance = new PartialClass();
            instance.MethodFromPart1();
            instance.MethodFromPart2();

            // Delay
            Console.ReadKey();
        }
    }
}
