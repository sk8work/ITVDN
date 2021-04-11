using System;

namespace _007_Constructors
{
    class NotStaticClass
    {
        // Конструктор экземпляра вызывается только при создании экемпляра класса
        public NotStaticClass()
        {
            Console.WriteLine("Constructor");
        }

        // Статический конструктор вызывается в любом случае
        // как при обращении к статическому члену, так и при создании экземпляяра класса
        static NotStaticClass()
        {
            Console.WriteLine("StaticConstructor");
        }

        // Статический метод
        public static void StaticMethod()
        {
            Console.WriteLine("StaticMethod");
        }

        public void NotStaticMethod()
        {
            Console.WriteLine("NotStaticMethod");
        }
    }
}
