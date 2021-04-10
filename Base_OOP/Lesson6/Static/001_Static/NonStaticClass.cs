using System;

namespace _001_Static
{
    class NonStaticClass
    {
        private int Id;
        public static int field;

        // Constructor
        public NonStaticClass(int Id)
        {
            this.Id = Id;
        }

        public void Method()
        {
            Console.WriteLine("Instance{0}.field = {1}", Id, field);
        }
    }
}
