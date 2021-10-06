using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Address
    {
        public Address()
        {

        }
        public Address(Address existing)
        {
            Street = existing.Street;
            City = existing.City;
        }
        public string Street { get; set; }

        public string City { get; set; }
    }
}