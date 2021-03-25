using System;

namespace _002_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();

            Console.WriteLine(instance.publicField);
            instance.Show();

            // Delay 
            Console.ReadKey();
        }
    }
}
