using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Person
    {
        public Person()
        {


        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FirstName { get; set; }
           
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Adress HomeAddress { get; set; } = new Adress();

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public override string ToString()
        {
            return GetFullName();
        }

        public int Age()
        {
           return  DateTime.Now.Year - DateOfBirth.Year;
        }


    }
}
