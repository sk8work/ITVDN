using System;

// Indexers (override)

namespace _006_Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            BaseClass instance1 = instance as BaseClass;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(instance1[i]);
            }

            // Delay
            Console.ReadKey();
        }
    }
}
