﻿using System;

// Расширяющие методы (Extension methods)

// Аргумент расширения всегда должен быть один и стоять первым в списке аргументов

namespace _002_Extension
{
    static class ExtensionClass
    {
        public static void ExtensionMethod(this string value1, string value2)
        {
            Console.WriteLine(value1 + value2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello ";

            text.ExtensionMethod("World!");

            //Delay
            Console.ReadKey();
        }
    }
}
