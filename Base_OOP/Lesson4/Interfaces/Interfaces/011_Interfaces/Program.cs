using System;

namespace _011_Interfaces
{
    interface IGoEater
    {
        void Go();
        void Eat();
    }

    interface ISecurity : IGoEater
    {
        void Guard();
    }
    class Dog : ISecurity
    {
        public void Go()
        {
            Console.WriteLine("Dog step");
        }

        public void Eat()
        {
            Console.WriteLine("Dog style eat");
        }

        public void Guard()
        {

        }
    }

    class Cat : IGoEater
    {
        public void Go()
        {
            Console.WriteLine("Cat step");
        }

        public void Eat()
        {
            Console.WriteLine("Cat style eat");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ISecurity dog = new Dog();
            IGoEater cat = new Cat();

            dog.Go();
            dog.Eat();
            dog.Guard();

            cat.Go();
            cat.Eat();

            // Delay
            Console.ReadKey();
        }
    }
}
