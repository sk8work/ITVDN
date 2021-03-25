using System;
using System.Collections.Generic;
using System.Text;

namespace _008_BaseMethod
{
    class DerivedClass : BaseClass
    {
        public override void Method()
        {
            base.Method();

            Console.WriteLine("Metohod from DerivedClass");
        }
    }
}
