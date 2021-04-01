using System;

namespace _003_MultipleAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int apples = 5, pears = 3, fruits = apples + pears;

            Console.WriteLine(fruits);*/

            ulong bit = 1;
            ulong Byte = bit << 3;
            ulong KByte = bit << 10;
            ulong MByte = bit << 20;
            ulong GByte = bit << 30;


            Console.WriteLine(bit);
            Console.WriteLine(Byte + " " + 1*8);
            Console.WriteLine(KByte * 8 + " " + 1 * 8 * 1024);
            Console.WriteLine(MByte * 8 + " " + 1 * 8 * 1024 * 1024);
            Console.WriteLine("1.5 GB = " + GByte * 8 * 1.5);

            // Delay
            Console.ReadKey();
        }
    }
}
