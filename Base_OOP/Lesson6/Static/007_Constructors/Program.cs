using System;

// Статический конструктор

namespace _007_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Вариант (Вызывается только СТАТИЧЕСКИЙ конструктор)
            // NotStaticClass.StaticMethod();

            // 2. Вариант (Вызываются оба конструктора)
            new NotStaticClass().NotStaticMethod();

            // Delay
            Console.ReadKey();
        }
    }
}
