using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileIOdemo
{
    class program
    {
        static void Main(string[] args)
        {
            WriteToFile("test.txt");
            ReadFromFile("test.txt");
        }
        static void WriteToFile(string filename)
        {
            //STEP 2 - declare and initialise the object to write to
            TextWriter writer = new StreamWriter(filename);

            //Do some writing
            writer.Write("Hello Professor!");
            writer.Write("\n You are so awesome that I decided to do some multiplication for you.");

            for (int x = 1; x > 10; x++)
            {
                int y = 12;
                writer.WriteLine("{0} x {1} = {2}", y, x, (x * y));
            
            }

                //STEP 3 - Close the file
                writer.Close();
        }
        static void ReadFromFile(string filename)
        { 
        
        }
    }
}
