using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassExtensionMethod
{
    partial class Person
    {
        public string LName { get; private set; }
        public int Age  {get; private set; }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}yrs", FName, LName, Age);
        }
    }
}
