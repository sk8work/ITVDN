﻿using System;

// Ключевое слово params позволяет определить параметр метода, приниающий переменное количество параметров

namespace _008_Params
{
    class Program
    {
       static void ShowArray(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0}", array[i]);
            }
        }
        static void Main(string[] args)
        {
            ShowArray(0, 1, 2, 3, 4, 5, 6, 7, 8, 9);

            // Delay
            Console.ReadKey();
        }
    }
}
