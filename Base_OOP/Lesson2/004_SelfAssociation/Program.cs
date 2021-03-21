using System;

// Самоассоциация (self-association)

namespace Classes
{
    class Program
    {
        public void Method()
        {
            Console.WriteLine("Hello World!");
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            program.Method();

            // Delay
            Console.ReadKey();
        }
    }
}
