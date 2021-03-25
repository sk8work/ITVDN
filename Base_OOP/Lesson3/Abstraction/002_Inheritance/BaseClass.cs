using System;

// Inheritance

namespace _002_Inheritance
{
    class BaseClass
    {
        // Fields

        public string publicField = "BaseClass.publicField";
        private string privateField = "BaseClass.privateField";
        protected string protectedField = "BaseClass.protectedField";

        // Methods

        public void Show()
        {
            Console.WriteLine(privateField);
        }
    }
}
