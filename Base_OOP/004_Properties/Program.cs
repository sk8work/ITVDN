using System;

// Классы (использование свойств для доступа к закрытым классам)

namespace _004_Properties
{
    class MyClass
    {
        string field = null;

        public string Field
        {
            set
            {
                if (value == "fool")
                    Console.WriteLine("Вы ввели недопустимое значение. Повторите попытку");
                else
                    field = value;
            }
            get
            {
                if (field == null)
                    return "В поле отсутствуют данные.";
                else if (field == "hello world")
                    return field.ToUpper() + "!";
                else
                    return field;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();

            instance.Field = "fool";
            Console.WriteLine(instance.Field);

            Console.WriteLine(new string('-', 50));

            instance.Field = "hello world";
            Console.WriteLine(instance.Field);

            // Delay
            Console.ReadKey();
        }
    }
}
