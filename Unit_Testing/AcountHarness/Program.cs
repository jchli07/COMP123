using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountLibrary; //need to add a reference to the library project

namespace AcountHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account("Narendra");
            a.Withdraw(10);
            Console.WriteLine(a);
        }
    }
}
