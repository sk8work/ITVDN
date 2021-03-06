using System;

// Расширяющие методы (Extension methods)

// рекурсия (простая)

namespace _004_Extension
{
    static class ExtensionClass
    {
        public static void ExtensionMethod(this string value, int counter)
        {
            counter--;
            Console.WriteLine(value + counter);

            if (counter != 0)
                value.ExtensionMethod(counter);

            Console.WriteLine(value + counter);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello";

            text.ExtensionMethod(3);

            // Delay
            Console.ReadKey();
        }
    }
}
