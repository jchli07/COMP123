using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CourseDemo
{
    class CourseManager
    {
        static List<Course> courses = new List<Course>();

        public static void Display(DisplayOption option, string toMatch = "")
        {
            // look up case- switch
        }
        public static void LoadCourses(string filename)
        {
            TextReader reader = new StreamReader(filename);

            string Code;
            string Description;
            string Name;
            string Prerequsite;
            string Semester;

            Code = reader.ReadLine();
            
            while (Code != null)
            {
                Code = reader.ReadLine();
                Description = reader.ReadLine();
                Name = reader.ReadLine();
                Prerequsite = reader.ReadLine();  
                Semester = reader.ReadLine();
            }


        }
    }
}
