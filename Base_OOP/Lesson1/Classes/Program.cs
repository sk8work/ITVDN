using System;

namespace Classes
{

    class Butterfly
    {
        public string name;
        public int field;

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
        static void Main(string[] args)
        {
            Butterfly mahaon = new Butterfly();
            // mahaon.name = "Admiral";
            Console.WriteLine(mahaon.field);
            mahaon.Fly();

            // Delay
            Console.ReadKey();
        }
    }
}
