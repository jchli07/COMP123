using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassExtensionMethod
{
    partial class Person
    {
        public string FName { get; private set; }
        public Person(string fname, string lname, int age)
        {
            FName = fname;
            LName = lname;
            Age = age;
        }
    }
}
