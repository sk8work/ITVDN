using System;

namespace _007_Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivadClass instance = new DerivadClass();
            instance.Method();

            // UpCast
            BaseClass instanceUp = instance;
            instanceUp.Method();

            // DownCast
            DerivadClass instanceDown = (DerivadClass)instanceUp;
            instanceDown.Method();

            // Delay
            Console.ReadKey();
        }
    }
}
