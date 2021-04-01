using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document("Контракт");
            document.Body = "Тело контракта...";
            document.Footer = "Директор: Иванов И.И.";

            document.Show();

            Console.WriteLine(new string('-', 50));

            Document doc2 = new Document("Контракт 2");
            document.Body = "Hello";
            doc2.Footer = "Bye";

            doc2.Show();

            // Delay
            Console.ReadKey();
        }
    }
}
