using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main()
        {
            //test the Parts class
            Console.WriteLine("\n*****Testing the Parts Class");
            Console.WriteLine(new Parts("Alternator", 5.21));
            Console.WriteLine(new Parts("Piston", 14.99, 4));
            Console.WriteLine(new Parts("Battery", 124.98, 2, false));

            //test the Store class
            Console.WriteLine("\n*****Testing the Store Class");
            Console.WriteLine(new Store("103", "M1B-6E8"));

            //testing InsertPart method of the Store class
            Console.WriteLine("\n*****Testing the InsertPart()");
            Store store0 = new Store("126", "M1T-5G4");
            store0.InsertPart(new Parts("Rims", 199.97, 5));
            store0.InsertPart(new Parts("Tire", 75, 4, false));
            store0.InsertPart(new Parts("Brake pad", 28, 6, true));
            store0.InsertPart(new Parts("Oil filter", 14, 12, false));

            Console.WriteLine(store0);

            Console.WriteLine("\n*****Testing the InsertPart()");
            Store store1 = new Store("135", "K2E-9T7");
            store1.InsertPart(new Parts("Muffler", 37, 1, false));
            store1.InsertPart(new Parts("Bulb", 1.45));
            store1.InsertPart(new Parts("Rearview mirror", 6.16, 2, false));
            store1.InsertPart(new Parts("Ignition switch", 42, 3, true));
            store1.InsertPart(new Parts("Air pump", 7));
            store1.InsertPart(new Parts("Carburetor", 21));

            Console.WriteLine(store1);

            Console.WriteLine("\n*****Saving to \"Parts.xml\"");
            store1.SaveAsXml("parts.xml");

            //testing the RemovePart method of the Store class
            //check the previous display to verify that atleast
            //two of the partId are used below
            Console.WriteLine("\n*****Testing the RemovePart()");
            store1.RemovePart("100008");
            store1.RemovePart("100009");

            try
            {
                store1.RemovePart("100008");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(store1);

            Console.Write("... Press enter to exit");
            Console.ReadLine();
        }
    }
}
