using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadFile
{
    class Program
    {
        static void Main (string[] args)
        {
            ReadFromFile("test.txt");
        }
        static void WriteToFile(string filename)

        static void ReadFromFile(string filename)
        {
            TextReader reader = new StreamReader(filename);

            string input = reader.ReadToEnd();
            int i = 1;
            while (input !=null)
            {
                Console.WriteLine(i++ + ": " + input);
                input = reader.ReadLine();
            }

            reader.Close();
        
        
        }

    }
}
