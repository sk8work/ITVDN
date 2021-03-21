using System;
using System.Collections.Generic;
using System.Text;

namespace _007_Virtual
{
    class DerivedClass : BaseClass
    {
        // Переопределение метода базового класса

        public override void Method()
        {
            Console.WriteLine("Method from DerivedClass");
        }
    }
}
