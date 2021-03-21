using System;

// Наследование

namespace _002_Inheritance
{
    class BaseClass
    {
        // Поля

        public string publicField = "BaseClass.publicField";
        private string privateField = "BaseClass.privateField";
        protected string protectedField = "BaseClass.protectedField";

        // Методы

        public void Show()
        {
            Console.WriteLine(privateField);
        }
    }
}
