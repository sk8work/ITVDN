using System;
using System.Collections.Generic;
using System.Text;

namespace _006_Inheritance
{
    class DerivedClass : BaseClass
    {
        // Замещение метода базового класса
        public void Method()
        {
            Console.WriteLine("Method from DerivedClass");
        }
    }
}
