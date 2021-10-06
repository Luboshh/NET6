using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Person : INamed
    {
        public Person()
        {
            HomeAddress = new Address();
        }

        public Person(string firstName, string lastName) : this()
        {
            FirstName = firstName;
            LastName = lastName;
        }


        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Address HomeAddress { get; set; } = new Address();
        public string Name { get => GetFullName(); set => FirstName = value; }

        public void Print() => Console.WriteLine("person: " + GetFullName());
        public int Age()
        {
            return DateTime.Now.Year - DateOfBirth.Year;

        }
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public override string ToString()
        {
            return GetFullName() + " " + HomeAddress.City;
        }
    }
}