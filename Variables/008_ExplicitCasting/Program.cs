using System;

namespace _008_ExplicitCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueOfGreaterType = 256;
            byte valueOfLowerType = (byte)valueOfGreaterType;

            Console.WriteLine(valueOfGreaterType);
            Console.WriteLine(valueOfLowerType);

            // Delay
            Console.ReadKey();
        }
    }
}
