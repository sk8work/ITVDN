using System;

namespace Classes
{
    class MyClass
    {
        private string field = null;

        public void SetField(string value)
        {
            field = value;
        }

        public string GetField()
        {
            return field;
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass instance = new MyClass();
            instance.SetField("Hello world!");

            string @string = instance.GetField();
            Console.WriteLine(@string);

            // Delay
            Console.ReadKey();
        }
    }

}