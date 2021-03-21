using System;



namespace Classes
{
    class Point
    {
        // Поля
        private int x, y;
        private string name;

        // Свойства
        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public string Name
        {
            get { return name; }
        }

        // Конструкторы

        // Использование ключевого слова this в конструкторе с одним параметром
        // приводит к вызову этого конструктора
        public Point(int x, int y)
        {
            Console.WriteLine("Конструктор с двумя параметрами!");
            this.x = x;
            this.y = y;
        }

        // Использование ключевого слова this в конструкторе приводит к вызову констркторы с двумя параметрами
        public Point(string name)
            : this(300, 400)
        {
            Console.WriteLine("Конструктор с одним парамметром!");
            this.name = name;
        }
    }
}
