using System;

// Наследование
// 
// Наследование - механизм ООП, позволяющий описать новый (производный) класс
// на основе уже существующего (базового),
// при этом свойства и функциональность базового класса заимствуются новым классом.

//  Базовй класс        -   Производный класс
//  Супер класс         -   Подкласс (сабкласс)
//  Родитеьский класс   -   Дочерний класс
//  Родитель            -   Потомок

namespace _001_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass instance = new DerivedClass();

            Console.WriteLine(instance.publicField);

            // Delay
            Console.ReadKey();
        }
    }
}
