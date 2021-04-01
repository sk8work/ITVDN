using System;

// Самоассоциация (self-association)

namespace Classes
{
    class MyClass
    {
        MyClass instance;

        public MyClass() // StackOverfloException
        {
            Console.WriteLine("Constructor MyClass");

            // Самассоцияция. После первой попытки инстанцированияи приводит к цикличному инстанцированию

            instance = new MyClass();
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            // Попытка инстанцирования класса MyClass

            MyClass instance = new MyClass();            

            // Delay
            Console.ReadKey();
        }
    }
}
