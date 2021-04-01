using System;

// Конструкторы

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Применяем конструктор по-умолчанию
            Point pointA = new Point(100, 200);
            Console.WriteLine("pointA.X = {0}, pointA.Y = {1}", pointA.X, pointA.Y);

            Console.WriteLine(new string('-', 30));

            // Применяем конструктор с параметрами
            Point pointB = new Point("NewPoint");
            Console.WriteLine("pointB.Name = {0}, pointB.X = {1}, pointB.Y = {2}", pointB.Name, pointB.X, pointB.Y);

            // Delay
            Console.ReadKey();
        }
    }
}
