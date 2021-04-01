using System;

// Абстрактный класс может быть унаследован от абстрактного класса
// Реализация абстрактного метода из базового абстрактного класса
// в производном абстрактном классе НЕ ОБЯЗЯТЕЛЬНА.

namespace _003_Abstraction
{
    // Абстрактный класс А.
    abstract class AbstractClassA
    {
        public abstract void OperationA();
    }

    // Абстрактный класс В.
    abstract class AbstractClassB : AbstractClassA
    {
        public abstract void OperationB();
    }

    // Конкретный класс.
    class ConcreteClass : AbstractClassB
    {
        public override void OperationA()
        {
            Console.WriteLine("ConcreteClass.OperationA");
        }

        public override void OperationB()
        {
            Console.WriteLine("ConcreteClass.OperationB");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClassA instance = new ConcreteClass();

            instance.OperationA();

            //instance.OperationB(); // Вопрос: почему недоступен данный метод?

            // Delay
            Console.ReadKey();
        }
    }
}
