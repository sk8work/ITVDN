using System;
using System.Collections.Generic;
using System.Text;

namespace _008_base.Method
{
    class DerivedClass : BaseClass
    {
        // Переопределение метода базового класса

        public override void Method()
        {
            // Вызов базвго метода
            base.Method();

            Console.WriteLine("Method from DerivedClass");
        }
    }
}
