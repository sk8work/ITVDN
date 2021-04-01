using System;

// Классы. (Использование свойств для доступа к закрытым полям.)

// Свойство - интерфейс доступа к полю объекта.
// Свойства в C# - поля с логическим блоком, в котором есть ключевое слово get и set
// и является суррогатом для замены методов доступа к полю.
// При обращении к свойству вызывается определенный метод, который выполняет определенные операции с объектом.

namespace _003_Properties
{
   class MyClass
    {
        private string field = null;

        public string Field
        {
            set
            {
                field = value;
            }

            get
            {
                return field;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            instance.Field = "Hello world!!!";

            Console.WriteLine(instance.Field);

            // Delay
            Console.ReadKey();
        }
    }
}
