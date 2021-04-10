using System;

// Indexers

namespace _003_Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();

            for (int i = 0; i < 6; i++)
            {
                my[i] = string.Format("string {0}", i);
            }

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(my[i]);
            }

            // Delay
            Console.ReadKey();
        }
    }
}
