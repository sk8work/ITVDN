using System;
using System.Collections.Generic;
using System.Text;

namespace _003_Constructors
{
    class DerivedClass : BaseClass
    {
        public int derivedField;

        /*public DerivedClass()
        {
        }*/

        public DerivedClass(int number1, int number2)
        {
            baseNumber = number1;

            derivedField = number2;
        }
    }
}
