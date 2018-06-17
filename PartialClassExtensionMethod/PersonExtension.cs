using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassExtensionMethod
{
    //extension method must be contained in static class
    class PersonExtension
    {
        public static string MakeFirstLetterUpperCase(this Person p )
        {
            string result = p.FName.Substring(0,1).ToUpper();
            result += p.FName.Substring(1, p.FName.Length - 1).ToLower();
            result += " ";
            result += p.LName.Substring(0, 1).ToUpper();
            result += p.LName.Substring(1, p.LName.Length - 1).ToLower();
            return result;
        }
        public static int Square(this int x)
        {
            return x * x;
        }
    }
}
