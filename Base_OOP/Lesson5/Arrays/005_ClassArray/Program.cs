using System;

// Abstract class Array

// All arrays are derived from class Array

namespace _005_ClassArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = { 1, 2, 3 };

            Array array = vector as Array;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }

            // Delay
            Console.ReadKey();
        }
    }
}
