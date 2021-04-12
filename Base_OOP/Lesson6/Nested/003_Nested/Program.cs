using System;

// Nested classes

namespace _003_Nested
{
    class MyClass
    {
        private int field = 0;
        
        public class Nested
        {
            MyClass instanse = new MyClass();

            public void Method(int a)
            {
                instanse.field = a;
                Console.WriteLine(instanse.field);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass.Nested instance = new MyClass.Nested();

            instance.Method(1);

            // Delay
            Console.ReadKey();
        }
    }
}
