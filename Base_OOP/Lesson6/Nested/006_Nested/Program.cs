using System;

// Nested classes

// Статические классы могут в себе содержать нестадические Nested классы

namespace _006_Nested
{
    public static class MyClass
    {
        static MyClass()
        {
            Console.WriteLine("Статический конструктор MyClass");
        }

        public static void StaticMethod()
        {
            Console.WriteLine("Статический метод класса MyClass");
        }

        public class Nested
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
            MyClass.StaticMethod();

            MyClass.Nested instance = new MyClass.Nested();
            instance.MethodFromNested();

            // Delay
            Console.ReadKey();
        }
    }
}
