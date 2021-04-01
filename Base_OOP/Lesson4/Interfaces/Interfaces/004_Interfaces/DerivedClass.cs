﻿using System;

// В С# допустимо множественное наследование только от интерфейсов.
// Множественное наследование реализации (т.е. от двух и более классов или структур) недопустимо
// Допустимо множественное наследование от одного класса и многих интерфейсов

namespace _004_Interfaces
{
    class DerivedClass : BaseClass, Interface1, Interface2
    {
        public void Method1()
        {
            Console.WriteLine("Реализация метода Method1() из Interface1");
        }

        public void Method2()
        {
            Console.WriteLine("Реализация метода Method2() из Interface2");
        }
    }
}
