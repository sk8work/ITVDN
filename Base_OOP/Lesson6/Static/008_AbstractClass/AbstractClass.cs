using System;

namespace _008_AbstractClass
{
    abstract class AbstractClass
    {
        // Статическй фабричный метод
        public static AbstractClass CreateObject()
        {
            return new ConcreteClass();
        }
        public abstract void Method();
    }
}
