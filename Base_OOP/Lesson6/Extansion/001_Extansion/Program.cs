using System;

// Расширяющие методы (Extansion methods)

// Расширяющие методы могут быть только статическими и создаваться только в статических классах

namespace _001_Extansion
{
    static class ExtansionClass
    {
        // this - сообщает компилятору, что данный метод является расширяющим (Extansion)!
        public static void ExtansionMethod(this string value)
        {
            Console.WriteLine(value);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Тестовая строка";

            //Вызов метода, как статического
            ExtansionClass.ExtansionMethod(text);

            // Вызов метода, как расширяющего
            text.ExtansionMethod();

            // Delay
            Console.ReadKey();
        }
    }
}
