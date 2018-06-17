using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyDemo
{
    //this is the base class
    class Person
    {
        public string FName { get; private set; }
        public string LName { get; private set; }
        public string Address { get; private set; }
        public int Age { get; private set; }
        public Person() { }

        public Person(string fname, string lname, string address, int age)
        {
            FName = fname;
            LName = lname;
            Address = address;
            Age = age;
        }
        public virtual void Duties()
        {
            Console.WriteLine("I don't do anything");
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", FName, LName, Address, Age);
        }

    }
}
