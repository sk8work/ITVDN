using System;

namespace _002_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            NotStaticClass instance = new NotStaticClass(1);

            //instance.Method();
            NotStaticClass.Method();
        }
    }
}
