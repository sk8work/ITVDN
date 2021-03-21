using System;

namespace _004_Abstraction
{
   
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteDerivedClass instance = new ConcreteDerivedClass();

            instance.SimpleMethod();
            instance.VirtualMethod();
            instance.AbstractMethod();

            // Delay
            Console.ReadKey();
        }
    }
}
