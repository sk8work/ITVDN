using System;

// Классы (использование свойств для доступа к закрытым полям)

namespace Clssses
{
    class MyClass
    {
        string field = null;

        public string Field
        {
            set
            {
                if (value.ToLower() == "fool")
                    Console.WriteLine("Выы ввели недопустимое значение. Повторите попытку.");
                else
                    field = value;
            }

            get
            {
                if (field == null)
                    return "В поле field отсуттвуют данные.";
                else if (field.ToLower() == "hello world")
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

            instance.Field = "Goodbye";
            Console.WriteLine(instance.Field);

            Console.WriteLine(new string('-', 50));

            instance.Field = "Hello world";
            Console.WriteLine(instance.Field);

            // Delay
            Console.ReadKey();
        }
    }
}
