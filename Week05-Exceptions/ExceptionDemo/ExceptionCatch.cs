using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ExceptionDemo
{
    class ExceptionCatch
    {
        public static void RunAllTest()
        {
            DoDivision();
            DoFileException();
            DoArrayIndexOutOfBounds();
            DoFormatException();
            DoSomethingDangerous();
            Console.WriteLine("\nProgram terminated normally");
        }
        static void DoSomethingDangerous()
        {
            int a = 1, b = int.MaxValue;
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);

            try
            {
                //this raises an exception if there is an overflow
                int c = checked(a + b);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        static void DoFormatException()
        {
            try
            {
                Convert.ToDouble("Hello");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        static void DoArrayIndexOutOfBounds()
	{
	    int[] primes = new int[] { 2, 3, 5, 7 };
	    try
	    {
	        Console.WriteLine(primes[4]);
	    }
	    catch (IndexOutOfRangeException e)
	    {
	        Console.WriteLine(e.Message);
	    }
        }
        static void DoFileException()
        {
            string filename = "boo.txt";
            try
            {
                StreamReader reader = new StreamReader(filename);
                reader.ReadLine();
                reader.Close();
                StreamWriter writer = new StreamWriter(filename);
                writer.WriteLine("Narendra is evil");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void DoDivision()
        {
            int a = 1, b = 0;
            try
            {
                //will cause an exception
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException david)
            {
                Console.WriteLine(david.Message);
            }
        }
    }
}
