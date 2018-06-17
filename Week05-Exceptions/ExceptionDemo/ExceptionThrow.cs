using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class ExceptionThrow
    {
        public static void RunAllTest()
        {
            DoNameTestWithoutCrash();
            DoNameTestWithoutCrashAndMoreLogic();
            //DoReThrow();
            DoThrowAndCatch();
            Console.WriteLine("\nProgram terminated normally\n\n");
        }

        static void DoThrowAndCatch()
        {
            int astronautCount = 5;
            try
            {
                if (astronautCount >= 5)
                    throw new Exception("Biosphere limit exceeded");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void DoReThrow()
        {
            try
            {
                DoNameTest();
            }
            catch (Exception e)
            {
                //throw e;
                throw new Exception("David is now the super villian");
            }
        }
        static void DoNameTestWithoutCrashAndMoreLogic()
        {
            try
            {
                DoNameTest();
            }
            catch (Exception e)
            {
                Console.WriteLine("Mary had a little lamb\nit's fleece was as white as snow\nIt followed her to school one day");
                Console.WriteLine(e.Message);
            }
        }
        static void DoNameTestWithoutCrash()
        {
            try
            {
                DoNameTest();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
         static void DoNameTest()
         {
             string name = "narendra";
             if (name == "narendra")
                 throw new Exception("Narendra is super evil");
         }
    }
}
