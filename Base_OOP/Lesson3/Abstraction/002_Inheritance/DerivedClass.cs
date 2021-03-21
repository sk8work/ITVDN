using System;
using System.Collections.Generic;
using System.Text;

namespace _002_Inheritance
{
    class DerivedClass : BaseClass
    {
        // Конструктор
        public DerivedClass()
        {
            publicField = "DerivedClass.publicField";
            protectedField = "DerivedClass.protetedField";
        }
    }
}
