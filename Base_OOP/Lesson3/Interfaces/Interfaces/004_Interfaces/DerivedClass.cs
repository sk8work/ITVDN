﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _004_Interfaces
{
    class DerivedClass : BaseClass, Interface1, Interface2
    {
        public void Method1()
        {
            Console.WriteLine("Реализация метода Method1() из Interface1");
        }

        public void Method2()
        {
            Console.WriteLine("Реализация метода Method2() из Interface2" );
        }
    }
}
