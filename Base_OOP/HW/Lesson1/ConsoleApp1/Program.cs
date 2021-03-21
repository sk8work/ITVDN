using System;

namespace hw1
{
    class Program
    {

        static void Main(string[] args)
        {

            Address address1 = new Address()
            {
                Index = "454085",
                Country = "Russia",
                City = "Chelyabinsk",
                Street = "Tankistov",
                House = "193C",
                Apartment = "98"
            };
            
            address1.ShowAddress();

            Console.WriteLine(new string('-', 50));

            Address address2 = new Address();
            address2.ShowAddress();
            Address address3 = new Address();
        }
    }
}
