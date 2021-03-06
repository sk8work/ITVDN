using System;

// Jagged Arrays

namespace _004_Jagged
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[3][];

            jagged[0] = new int[] { 1, 2 };
            jagged[1] = new int[] { 1, 2, 3, 4, 5 };
            jagged[2] = new int[] { 1, 2, 3 };

            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write("{0}", jagged[i][j]);
                }
                Console.WriteLine();
            }

            // Delay
            Console.ReadKey();
        }
    }
}
