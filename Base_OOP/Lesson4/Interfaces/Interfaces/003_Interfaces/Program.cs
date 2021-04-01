using System;

// Явное указание имени интерфейса в имени метода

namespace _003_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();

            // instance. -- // на экземпляре не видим методов интерфейсов

            // Приведем типы к базовым интерфейсам

            Interface1 instance1 = instance as Interface1;
            instance1.Method();

            Interface2 instance2 = instance as Interface2;
            instance2.Method();

            // Delay 
            Console.ReadKey();
        }
    }
}
