using System;

namespace _007_TypeConversions
{
    class Program
    {
        static void Main(string[] args)
        {
            byte valueOfLowerType = 255;
            int valueOfGreaterType = valueOfLowerType;  // Преобразование типа

            Console.WriteLine(valueOfLowerType);
            Console.WriteLine(valueOfGreaterType);

            // Delay
            Console.ReadKey();
        }
    }
}
