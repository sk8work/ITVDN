﻿using System;

// Классы

namespace Classes
{
    // Создаем класс с именем myClass/
    // В теле класса создаем открытое поле типа string с именем field и метод с именем Method()

    class MyClass
    {
        public string field;

        public void Method()
        {
            Console.WriteLine(field);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. Создаем экземпляр класса MyClass (по сильной ссылке).
            // 2. Создаем экземпляр класса MyClass с именем instance.
            // 3. Инстанцируем класс MyClass.
            // 4. Создаем переменную с именем instance типа MyClass и присваиваем ей адрес экземпляра на куче.
            // (instance - является ссылкой на экземпляр класса MyClass построенный на куче)

            MyClass instance = new MyClass();

            // Полю field экземпляра класса instance присваиваем значение Hello world!
            instance.field = "Hello world!";

            // Выводим на экран значение поля field экземпляра instance.
            Console.WriteLine(instance.field);
            Console.WriteLine(instance.GetHashCode());

            //Вызов метода с именем Method на экземпляре instance/
            instance.Method();

            // Delay
            Console.ReadKey();
        }
    }
}
