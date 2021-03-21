using System;

namespace _004_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass(1, 2);

            Console.WriteLine(instance.baseNumber);
            Console.WriteLine(instance.derivedField);

            // Delay
            Console.ReadKey();
        }
    }
}
