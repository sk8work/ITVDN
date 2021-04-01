using System;

// Использование техники фабричных методов

namespace Classes
{
    class Circle
    {
        public Circle()
        {
            Console.WriteLine("Создан круг");
        }
    }

    class Square
    {
        public Square()
        {
            Console.WriteLine("Создан квадрат");
        }
    }

    class Factory
    {
        public Circle FactoryMethodCircle()
        {
            return new Circle();
        }
        public Square FactoryMethodSquare()
        {
            return new Square();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();

            Circle circle1 = factory.FactoryMethodCircle();
            Square square1 = factory.FactoryMethodSquare();

            // Delay
            Console.ReadKey();
        }
    }
}
