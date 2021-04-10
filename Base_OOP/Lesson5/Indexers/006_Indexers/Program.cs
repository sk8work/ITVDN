using System;

// Indexers

namespace _005_Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary dict = new Dictionary();

            Console.WriteLine(dict["книга"]);
            Console.WriteLine(dict["дом"]);
            Console.WriteLine(dict["ручка"]);
            Console.WriteLine(dict["стол"]);
            Console.WriteLine(dict["карандаш"]);
            Console.WriteLine(dict["яблоко"]);
            Console.WriteLine(dict["солнце"]);

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(dict[i]);
            }

            // Delay
            Console.ReadKey();
        }
    }
}
