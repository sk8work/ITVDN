using System;

// Nested classes

namespace _005_Nested
{
    public class MyClass : BaseClass
    {
        public class Nested // наследоване от BaseClass не распространяется
        {
            public void MethodFromNested()
            {
                Console.WriteLine("Метод Nested класса");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance1 = new MyClass();
            instance1.MethodFromBase();

            MyClass.Nested instance2 = new MyClass.Nested();
            instance2.MethodFromNested();

            // Delay
            Console.ReadKey();
        }
    }
}
