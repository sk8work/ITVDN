using System;

// Nested classes

namespace _004_Nested
{
    public class MyClass // Наследование от BaseClass не распространяется
    {
        public class Nested : BaseClass
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
            MyClass.Nested instance = new MyClass.Nested();
            instance.MethodFromBase();
            instance.MethodFromNested();

            // Delay
            Console.ReadKey();
        }
    }
}
