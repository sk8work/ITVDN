using System;

// Объект не может скрывать (инкапсулировать) ничего от другого объекта того же класса

namespace Classes
{
    class MyClass
    {
        MyClass my = null;

        private void Method()
        {
            Console.WriteLine("Hello!");
        }

        public void CallMethod()
        {
            my = new MyClass();

            // privat метод виден на экземпляре!
            my.Method();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            my.CallMethod();
            //my.Method(); //Недопустимо.

            // Delay
            Console.ReadKey();
        }
    }
}
