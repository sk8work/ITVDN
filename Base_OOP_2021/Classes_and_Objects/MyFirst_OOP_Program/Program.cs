using System;

namespace MyFirst_OOP_Program
{
    class MyClass
    {
        public int field;

        public void Method()
        {
            Console.WriteLine(field);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            instance.field = 5;
            instance.Method();

            Console.WriteLine("Hello World!");
        }
    }
}
