using System;

// Паттерн проектирования - Singleton

namespace _002_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Конструктор "protected" - невозможно использовать - new Singleton()
            Singleton instance1 = Singleton.Instance();
            Singleton instance2 = Singleton.Instance();

            if (instance1 == instance2)
                Console.WriteLine("Ссылки указывают на один экземпляр объекта");

            Console.WriteLine(instance1.GetHashCode());
            Console.WriteLine(instance2.GetHashCode());

            // Delay
            Console.ReadKey();
        }
    }
}
