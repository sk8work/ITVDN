using System;

// Классы. (Использование свойств для доступа к закрытым полям)

// Свойство - интерфейс доступа к полю объекта
// Свойства в С# - поля с логическим блоком, в котором ест ключевое слово get и set
// и являются суррогатом для замены методов доступа к полю
// При обращении к свойству вызывается метод, который выполняет определенные операции с объектом

namespace Classes
{
    class MyClass
    {
        private string field = null;

        public string Field
        {
            set // void SetField(string value)
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

            instance.Field = "Hello world!";

            Console.WriteLine(instance.Field);

            // Delay
            Console.ReadKey();
        }
    }
}
