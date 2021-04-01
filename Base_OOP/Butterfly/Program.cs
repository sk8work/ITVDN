using System;

namespace Butterfly
{
    class Butterfly
    {
        public string name;

        public void Fly()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Fly!");
            }
        }
    }
    class Program
    {

        static void Main()
        {
            Butterfly mahaon = new Butterfly();
            mahaon.name = "Admiral";
            mahaon.Fly();
        }
    }
}
