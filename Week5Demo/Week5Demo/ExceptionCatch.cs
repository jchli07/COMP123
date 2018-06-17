using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Week5Demo
{
    class ExceptionCatch
    {
        public static void RunAllTests()
        {
            DoDivision();
            DoFormatException();
            DoFileException();
            Console.WriteLine("\n Program Terminating Normally\n\n");
        }
        static void DoSomethingAwesome()
        {
            int a = 1, b = int.MaxValue;
            int c = a + b;
            Console.WriteLine("Danger output: {0}", c);
        }
        static void DoFileException()
        {
            try
            {
                StreamWriter writer = new StreamWriter("hey.txt");
                writer.WriteLine("Hello There");
            }
            catch (System.IO.FileNotFoundException e)
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
        static void DoFormatException()
        {
            try
            {
                Console.WriteLine(Convert.ToDouble("Hello"));
            }
            catch
            {
                Console.WriteLine(e.Message);
            }
        }
        static void DoDivision()
        {
            try
            {
                int a = 1, b = 0;
                int c = a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
