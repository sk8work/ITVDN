using System;

// Герметизированные классы (запечатанные классы)

namespace _011_Sealed
{
    sealed class SealedClass
    {
        public int x;
        public int y;
    }

    // Попытка наследования от SealedClass приводит к ошибке компилятора.

    class DerivedClass //: SealedClass  // Error
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            SealedClass instance = new SealedClass();
            instance.x = 100;
            instance.y = 200;

            Console.WriteLine("x = {0}, y = {1}", instance.x, instance.y);

            // Delay
            Console.ReadKey();
        }
    }
}
