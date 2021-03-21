using System;
using System.Collections.Generic;
using System.Text;

namespace hw1
{
    class Address
    {
        public Address()
        {

        }
        
        public string Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }

        public Address(string index, string country, string city, string street, string house, string apartment)
        {
            if (this.Index == null)
                this.Index = index;
            if (this.Country == null)
                this.Country = country;
            if (this.City == null)
                this.City = city;
            if (this.Street == null)
                this.Street = street;
            if (this.House == null)
                this.House = house;
            if (this.Apartment == null)
                this.Apartment = apartment;
        }

        public void ShowAddress()
        {
            Console.WriteLine($"Index: {this.Index}", this.Index);
            Console.WriteLine($"Country: {this.Country}", this.Country);
            Console.WriteLine($"City: {this.City}", this.City);
            Console.WriteLine($"Street: {this.Street}", this.Street);
            Console.WriteLine($"House: {this.House}", this.House);
            Console.WriteLine($"Apartment: {this.Apartment}", this.Apartment);
        }
    }
}
