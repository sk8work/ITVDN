using System;

// Автоматически реализуемые свойства (Auto-Implemented properties).

// Автоматически реализуемые свойства - это более лаконичная форма свойств, их есть смысл использовать,
// когда в методах доступа (get и set) не требуется дополнительная логика.
// При создании автоматически реализуемых свойств, компилятор создаст закрытое анонимное резервное поле,
// которое будет доступно с помощью методов get и set свойства.

namespace Classes
{
    class Program
    {
        public class Author
        {
            string name;
            // Автоматически реализуемые свойства.
            public string Name 
            { 
                get { return name; } 
                set
                {
                    if (value != "fool")
                        name = value;
                }
            }
            public string Book { get; set; }
        }

        static void Main(string[] args)
        {
            Author author1 = new Author()
            {
                Name = "Jeffrey Ritcher", // блок инициализатора.
                Book = "CLR via C#"
            };

            Author author2 = new Author  // ()  можем опустить скобки, если не принимает аргументов
            {
                Name = "Steve McConnell", // Блок инициализатор.
                Book = "Code Complete"
            };

            Console.WriteLine("Name: {0}, Book: {1}", author1.Name, author1.Book);
            Console.WriteLine("Name: {0}, Book: {1}", author2.Name, author2.Book);

            // Delay
            Console.ReadKey();
        }
    }
}
