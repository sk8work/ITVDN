using System;
using System.Collections.Generic;
using System.Text;

namespace _003_Constructors
{
    class BaseClass
    {
        public int baseNumber;

        // Конструктор по-умолчанию
        public BaseClass()
        {
        }

        // Пользовательский конструктор
        public BaseClass(int baseNumber)
        {
            this.baseNumber = baseNumber;
        }
    }
}
