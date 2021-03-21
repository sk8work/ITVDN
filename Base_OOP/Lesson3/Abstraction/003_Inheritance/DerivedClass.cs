﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _003_Constructors
{
    class DerivedClass : BaseClass
    {
        public int derivedField;

        // Конструктор по-умолчанию
        //public DerivedClass()
        //{
        //}

        // Пользовательский конструктор
        // При создании объекта производного класса, конструктор
        // производного класса автоматически вызывает конструктор
        // по-умолчанию из базового класса.
        // Конструктор базового класса присвоит всем данным какие-то
        // свои безопасные значения.
        // После этого начтен работу конструктор производного класса,
        // который повторно будет определять значени дял унаследованных
        // членов. (ДВОЙНАЯ РАБОТА)!
        public DerivedClass(int number1, int number2)
        {
            // Инициализируем поле базового класса
            baseNumber = number1;

            // Инициализируем поле производного (этого) класса
            derivedField = number2;
        }
    }
}