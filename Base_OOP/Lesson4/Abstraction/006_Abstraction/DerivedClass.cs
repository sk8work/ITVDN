using System;
using System.Collections.Generic;
using System.Text;

namespace _005_Abstraction
{
    class ConcreteDerivedClass : AbstractBaseClass
    {
        // Переопределяем виртуальный метод VirtualMethod() базового класса
        // Если мы не переопределим виртуальный метод, то будет использован 
        // метод из базового класса
        public override void VirtualMethod()
        {
            Console.WriteLine("DerivedClass.VirtualMethod();");
        }

        // Реализуем абстрактный метод AbstractMethod() базового
        // абстрактного класса
        public override void AbstractMethod()
        {
            Console.WriteLine("DerivedClass.AbstractMethod();");
        }
    }
}
