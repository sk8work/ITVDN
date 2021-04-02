using System;

// Arrays (2d array)

namespace _002_TwoDimension
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[,] array = new int[3, 3];

            // fill array by randoms
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = random.Next(0, 10);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("{0}", array[i,j]);
                }
            }

            // Delay
            Console.ReadKey();

        }
    }
}
