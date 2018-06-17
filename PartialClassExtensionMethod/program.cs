using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassExtensionMethod
{
    class program
    {
        static void Main(string[] args)
        {
            Person evil = new Person("toni", "lea", 16);
            Console.WriteLine(evil.MakeFirstLetterUpperCase());
            evil = new Person("Devin", "Young", 19);
            Console.WriteLine(evil);
        }
    }
}
