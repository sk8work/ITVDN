using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;

            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello, Friends!");

            Console.ResetColor();

            Console.WriteLine("Goobbye!"); // Reset settings

            Console.ReadKey(); // Delay
        }
    }
}
