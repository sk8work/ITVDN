﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Interfaces
{
    class DerivedClass : Interface1, Interface2
    {
        public void Method1()
        {
            Console.WriteLine("Реализация метода Method1() из Interface1");
        }

        public void Method2()
        {
            Console.WriteLine("Реализация метода Method2() из Interface2");
        }
    }
}
