using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDemo
{
    class Course
    {
        public string Code { get; private set; }
        public string Description { get; private set; }
        public string Name { get; private set; }
        public string Prerequsite { get; private set; }
        public int Semester { get; private set; }

        public Course(string Code, string Description, string Name, string Prerequsite, int Semester)
        {
            this.Code = Code;
            this.Description = Description;
            this.Name = Name;
            this.Prerequsite = Prerequsite;
            this.Semester = Semester;
        }

        public override string ToString()
        {
            return string.Format("{0} \n{1} \n{2} \n{3} \n{4}", Code, Name, Description, Semester, Prerequsite);
        }

    }
}
