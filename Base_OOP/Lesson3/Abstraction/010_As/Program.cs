using System;

// Cast с использованием опреатора as.

namespace _010_As
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();

            // UpCast
            BaseClass instanceUp = instance as BaseClass;
            if (instanceUp != null)
                instance.Method();

            // DownCast
            DerivedClass instanceDown = instanceUp as DerivedClass;
            instanceDown.Method();

            // Delay
            Console.ReadKey();
        }
    }
}
