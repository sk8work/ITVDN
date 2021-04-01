using System;
using System.Collections.Generic;

namespace DuplicateProducts
{
    class Ressult
    {
        public static int numDuplicates(List<string> name, List<int> price, List<int> weight)
        {
            name.ForEach(delegate (String name)
            {

            });

            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string a = "Hello";
            string b = "Hello";

            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}
