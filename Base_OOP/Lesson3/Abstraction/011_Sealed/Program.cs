using System;

// Sealed classes

namespace _011_Sealed
{
    sealed class SealedClass
    {
        public int x;
        public int y;
    }

    // Trying to inheriting from SealedClass returns ERROR

    class DerivedClass //: SealedClass
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            SealedClass instance = new SealedClass();
            instance.x = 100;
            instance.x = 200;

            Console.WriteLine("x = {0}, y = {1}", instance.x, instance.y);

            //Delay
            Console.ReadKey();
        }
    }
}
