using System;

// Параметр с ключевым словом params ддолжен бфть только один и стоять последним в списке параметров метода

namespace _009_Params
{
    class Program
    {
        static void ShowArray(string name, params int[] array)
        {
            Console.Write(name);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}", array[i]);
            }
        }
        static void Main(string[] args)
        {
            ShowArray("Numbers", 0, 1, 2, 3, 4, 5, 6, 7, 8, 9);

            // Delay
            Console.ReadKey();
        }
    }
}
