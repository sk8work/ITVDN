using System;

// Сьаьические члены в нестатических классах

namespace _006_StaticConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            NotStaticClass instance = new NotStaticClass();
            instance.NotStaticMethod();

            NotStaticClass.Property = 2;
            Console.WriteLine(NotStaticClass.Property);

            NotStaticClass.Method();
            NotStaticClass.Method(3);

            // Delay
            Console.ReadKey();
        }
    }
}
