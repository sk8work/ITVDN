using System;

//  as / is operators

namespace _009_IsAs
{
    class ClassA { }

    class ClassB : ClassA { }

    class Program
    {
        static void Main(string[] args)
        {
            ClassB b = new ClassB();
            ClassA a = null;

            if (b is ClassA)
                a = (ClassA)b;
            else
                a = null;

            a = b as ClassA;

            // Delay
            Console.ReadKey();
        }
    }
}
