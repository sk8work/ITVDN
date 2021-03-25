using System;
using System.Collections.Generic;
using System.Text;

// Inheritance

namespace _003_Constructors
{
    class BaseClass
    {
        public int baseNumber;

        // Constructor
        public BaseClass() { }

        // User Constructor
        public BaseClass(int baseNumber)
        {
            this.baseNumber = baseNumber;
        }
    }
}
