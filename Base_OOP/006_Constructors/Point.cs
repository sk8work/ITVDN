using System;

namespace _006_Constructors
{
    class Point
    {
        // Поля.
        private int x, y;

        // Свойства.
        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        // Конструктор по умолчанию. Инициализирует поля значениями по умолчанию.
        public Point()
        {
            Console.WriteLine("Конннструктор по умолчанию!");
        }

        // Пользовательский конструктор. Инициализирует поля значениями заданными пользователем.
        public Point(int x, int y)
        {
            Console.WriteLine("Пользовательский конструктор!");
            this.x = x;
            this.y = y;
        }
    }
}
