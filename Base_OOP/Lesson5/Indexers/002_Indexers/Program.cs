using System;

// Indexers

namespace _002_Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();

            my[0] = "string1";
            my[1] = "string2";
            my[2] = "string3";
            my[3] = "string4";
            my[4] = "string5";
            my[5] = "string6";

            Console.WriteLine(my[0]);
            Console.WriteLine(my[1]);
            Console.WriteLine(my[2]);
            Console.WriteLine(my[3]);
            Console.WriteLine(my[4]);
            Console.WriteLine(my[5]);

            // Delay
            Console.ReadKey();
        }
    }
}
