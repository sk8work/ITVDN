using System;
using System.Collections.Generic;
using System.Text;

namespace _004_Constructors
{
    class DerivedClass : BaseClass
    {
        public int derivedField;

        // Constructor
        public DerivedClass() { }

        // UserConstructor
        public DerivedClass(int number1, int number2)
            :base(number1)
        {
            derivedField = number1;
        }
    }
}
