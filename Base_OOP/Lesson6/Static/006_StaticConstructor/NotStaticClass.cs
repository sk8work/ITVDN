using System;

namespace _006_StaticConstructor
{
    class NotStaticClass
    {
        // Если класс содержит статические поля, должен быть предоставлен статический конструктор,
        // который инициализирует эти поля при загрузке класса

        private static int field;

        public static int Property
        {
            get { return field; }
            set { field = value; }
        }

        // Статический конструктор 
        // Единствунное назначение статических конструкторов - присваивать исходные значения статическим полям
        static NotStaticClass()
        {
            Console.WriteLine("Ствтический конструктор - NotStaticClass()");
            field = 1;
        }

        // Статические методы мгут быть перегружены
        public static void Method()
        {
            Console.WriteLine("Статический метод нестатического класса NotStaticClass");
        }

        // Статические метода могут быть перегружены
        public static void Method(int s)
        {
            Console.WriteLine("Перегруженный статический метод нестатического класса NotStaticClass " + s);
        }

        // Нестатический метод 
        public void NotStaticMethod()
        {
            Console.WriteLine(field);
        }
    }
}
