using System;
using System.Collections.Generic;
using System.Text;

namespace _001_Inheritance
{
    class DerivedClass : BaseClass
    {
        // Конструктор
        public DerivedClass()
        {
            // Изменяем все доступные поля, унаследованные от базового класса

            publicField = "DerivedClass.publicField";
            protectedField = "DerivedClass.protectedField";
        }
    }
}
