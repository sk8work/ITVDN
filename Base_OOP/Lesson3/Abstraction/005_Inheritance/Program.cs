using System;

namespace _005_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            DerivedClass instance1 = new DerivedClass();

            instance.field1 = 1;
            instance.field2 = 2;
            instance.field3 = 3;

            instance.field4 = 4;
            instance.field5 = 5;

            // Приведение экземпляра класса DerivedClass к базовому
            // типу BaseClass
            BaseClass newInstance = (BaseClass)instance; //  Upcast

            Console.WriteLine(newInstance.field1);
            Console.WriteLine(newInstance.field2);
            Console.WriteLine(newInstance.field3);

            // Console.WriteLine(newInstance.field4);
            // Console.WriteLine(newInstance.field5);

            // Проверка
            Console.WriteLine("instance Id          {0}", instance.GetHashCode());
            Console.WriteLine("instance1 Id         {0}", instance1.GetHashCode());
            Console.WriteLine("newInstance Id       {0}", newInstance.GetHashCode());

            // Delay
            Console.ReadKey();
        }
    }
}
