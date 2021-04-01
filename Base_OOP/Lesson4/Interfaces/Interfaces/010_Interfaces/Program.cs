using System;

// наследование от класса и интерфейса, у которых совпадают сигнетуры членов

namespace _010_Interfaces
{
    interface IInterface
    {
        void Method();
    }

    class BaseClass
    {
        public void Method()
        {
            Console.WriteLine("BaseClass.Method()");
        }
    }

    class DerivedClass : BaseClass, IInterface
    {
        // Реализация интерфейса не обязательна, т.к.
        // совпадают сигнатуры методов в классе и интерфейсе
    }
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            instance.Method();

            IInterface instance1 = instance as IInterface;
            instance1.Method();

            // Delay
            Console.ReadKey();
        }
    }
}
