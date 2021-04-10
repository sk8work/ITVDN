using System;

// Статические поля и свойства

namespace _004_Static
{
    class NotStaticClass
    {
        // Статическое поле
        static int field;

        // Статическое свойство
        public static int Property
        {
            get { return field; }
            set { field = value; }
        }
    }
}
