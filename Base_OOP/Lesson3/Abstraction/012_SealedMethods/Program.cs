﻿using System;

// Sealed methods

namespace _012_SealedMethods
{

    partial class ClassA
    {
        public virtual void Method1() { Console.WriteLine("ClassA.Method1"); }
        public virtual void Method2() { Console.WriteLine("ClassA.Method2"); }
    }
    partial class ClassA
    {
    }

    class ClassB : ClassA
    {
        public sealed override void Method1() { Console.WriteLine("ClassB.Method1"); }
        public override void Method2() { Console.WriteLine("ClassB.Method2"); }
    }

    class ClassC : ClassB
    {
        // public override void Method1() { Console.WriteLine("ClassC.Method1"); }
        public override void Method2() { Console.WriteLine("ClassC.Method2"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClassA instanceA = new ClassA();
            instanceA.Method1();
            instanceA.Method2();
        }
    }
}
