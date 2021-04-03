using System;

// Ковариантность в c#

namespace _007_Covariant
{
    public interface IAnimal
    {
        void Voice();
    }

    public class Dog : IAnimal
    {
        public void Voice()
        {
            Console.WriteLine("Voice");
        }

        public void Jump()
        {
            Console.WriteLine("Jump");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog[] dogs = { new Dog(), new Dog(), new Dog() };

            for (int i = 0; i < dogs.Length; i++)
            {
                dogs[i].Voice();
                dogs[i].Jump();
            }

            Console.WriteLine(new string('_', 10));

            IAnimal[] animal = dogs; // Ковариантность

            for (int i = 0; i < dogs.Length; i++)
            {
                animal[i].Voice();
                //
                // animal[i].Jump();
            }

            Console.WriteLine(new string('_', 10));

            dogs = (Dog[])animal; // Не является ковариантностью

            for (int i = 0; i < dogs.Length; i++)
            {
                dogs[i].Voice();
                dogs[i].Jump();
            }

            // Delay
            Console.ReadKey();
        }
    }
}
