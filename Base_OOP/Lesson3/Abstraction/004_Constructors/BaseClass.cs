using System;
using System.Collections.Generic;
using System.Text;

// Inheritance

namespace _004_Constructors
{
    class BaseClass
    {
        public int baseNumber;

        // Constructor
        public BaseClass() { }

        // User Constructor
        public BaseClass(int number)
        {
            this.baseNumber = number;
        }
    }
}
