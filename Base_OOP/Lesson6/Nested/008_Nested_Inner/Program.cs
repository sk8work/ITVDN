using System;

namespace _008_Nested_Inner
{
    // Inner класс

    public class OuterForInner
    {
        public void anOuterForInnerMethod()
        {
            Console.WriteLine("anOuterForInnerMethod");
        }

        public class Inner
        {
            public void anInnerMethod()
            {
                Console.WriteLine("anInnerMethod");
            }
        }
    }

    // Nested класс

    public class OuterForNested
    {
        public void anOuterForNestedMethod()
        {
            Console.WriteLine("anOuterForNestedMethod");
        }

        public static class NestedStatic
        {
            public static void aNestedStaticMethod()
            {
                Console.WriteLine("aNestedStaticMethod");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            OuterForInner instance1 = new OuterForInner();
            instance1.anOuterForInnerMethod();

            OuterForInner.Inner instance2 = new OuterForInner.Inner();
            instance2.anInnerMethod();

            OuterForNested instance3 = new OuterForNested();
            instance3.anOuterForNestedMethod();

            OuterForNested.NestedStatic.aNestedStaticMethod();

            // Delay
            Console.ReadKey();
        }
    }
}
