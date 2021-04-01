using System;

// readonly - поля только для чтения

namespace Classes
{
    class Program
    {
        // Поле только для чтения (учтанавливается только конструтором)!
        public readonly string field = "Hello";

        //Конструктор.
        public Program()
        {
            field = "Поле только для чтения ";

            field += "!";
        }
        
        static void Main(string[] args)
        {
            Program program = new Program();

            Console.WriteLine(program.field);

            // Ошибка компиляции.
            // program.field = "Попытка записи в поле только для чтения."

            // Delay
            Console.ReadKey();
        }
    }
}
