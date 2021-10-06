using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    interface INamed
    {
        public string Name { get; set; }

        public void Print();
    }

    class Student : INamed
    {
        public string Name { get; set; }

        public List<int> Grades { get; set; }

        public void Print() => Console.WriteLine("student: " + Name);

    }

    class Teacher : INamed
    {
        public string Name { get; set; }

        public double Salary { get; set; }

        public void Print() => Console.WriteLine("ucitel: " + Name);
    }
}