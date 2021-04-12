﻿using System;

// Nested classes

namespace _002_Nested
{
    class MyClass
    {
        private static int field = 0;

        public class Nested
        {
            public void Method(int a)
            {
                field = a;
                Console.WriteLine(field);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass.Nested instance = new MyClass.Nested();

            instance.Method(1);

            // Delay
            Console.ReadKey();
        }
    }
}
