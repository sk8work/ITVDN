using System;

// Arrays (1-Direction array)

namespace _001_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };

            array = new int[5];

            array = new int[5] { 1, 2, 3, 4, 5 };

            // Get elems of array
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            // Delay
            Console.ReadKey();
        }
    }
}
