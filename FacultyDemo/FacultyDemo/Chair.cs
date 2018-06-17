using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyDemo
{
    class Chair : Person
    {
        public string Department { get; private set; }
        public double Salary { get; private set; }
        public string Extension { get; private set; }

        public Chair(string fname, string lname, string address, string department, int age)
            : base(fname, lname, address, age)
        {
            Department = department;
        }

        //use the "new" keyword to hide the member in the base class
        new public void Duties()
        {
            Console.WriteLine("Take care of the entire department");
        }
        public override string ToString()
        {
            //use the base keyword to access members in the base class
            return string.Format("{0} {1} {2:c}", base.ToString(), Department, Salary);
        }
    }
}
