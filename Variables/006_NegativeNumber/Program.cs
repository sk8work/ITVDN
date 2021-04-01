using System;

namespace _006_NegativeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int negativeNumber = -1;
            uint naturalnumber = 4294967295;

            Console.WriteLine(negativeNumber);
            Console.WriteLine(naturalnumber);

            Console.WriteLine(Convert.ToString(negativeNumber, 2));
            Console.WriteLine(Convert.ToString(naturalnumber, 2));

            // Delay
            Console.ReadKey();
        }
    }
}
