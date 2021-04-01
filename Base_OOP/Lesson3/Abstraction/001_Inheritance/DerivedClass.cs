using System;
using System.Collections.Generic;
using System.Text;

namespace _001_Inheritance
{
    class DerivedClass : BaseClass
    {
        // Constructor.
        public DerivedClass()
        {
            // Changing all fields inherited from BaseClass

            publicField = "DerivedClass.publicField";
            protectedField = "DerivedClass.protectedField";
        }
    }
}
