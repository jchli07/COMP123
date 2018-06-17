using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    public class CollectionUtils
    {
        public static List<Course> CreateList()
        {
            return new List<Course>(){
            new Course() { Code = "COMP301", Name = "Operating Systems" },
            new Course() { Code = "COMP123", Name = "Programming II" },
            new Course() { Code = "COMP120", Name = "Software Engineering Fundamentals" },
            new Course() { Code = "COMP225", Name = "Systems Analysis and Design" },
            new Course() { Code = "COMP305", Name = "Game Programming I" },
            new Course() { Code = "COMP100", Name = "Programming I" },
            new Course() { Code = "COMP396", Name = "Game Programming II" },
            new Course() { Code = "COMP392", Name = "Advanced Graphics" },
            new Course() { Code = "COMP212", Name = "Programming III" },
            new Course() { Code = "COMP228", Name = "Advanced Java Programming" },
            new Course() { Code = "COMP214", Name = "Advanced Database" },
            new Course() { Code = "COMP124", Name = "Introduction to Databases" }
            };
        }
        public static Dictionary<string, Course> CreateDictionary()
        {
            Dictionary<string, Course> courses = new Dictionary<string, Course>();
            Course c = new Course() { Code = "COMP301", Name = "Operating Systems" };
            courses.Add(c.Code, c);
            c = new Course() { Code = "COMP123", Name = "Programming II" };
            courses.Add(c.Code, c);
            c = new Course() { Code = "COMP120", Name = "Software Engineering Fundamentals" };
            courses.Add(c.Code, c);
            c = new Course() { Code = "COMP225", Name = "Systems Analysis and Design" };
            courses.Add(c.Code, c);
            c = new Course() { Code = "COMP305", Name = "Game Programming I" };
            courses.Add(c.Code, c);
            c = new Course() { Code = "COMP100", Name = "Programming I" };
            courses.Add(c.Code, c);
            c = new Course() { Code = "COMP396", Name = "Game Programming II" };
            courses.Add(c.Code, c);
            c = new Course() { Code = "COMP392", Name = "Advanced Graphics" };
            courses.Add(c.Code, c);
            c = new Course() { Code = "COMP212", Name = "Programming III" };
            courses.Add(c.Code, c);
            c = new Course() { Code = "COMP228", Name = "Advanced Java Programming" };
            courses.Add(c.Code, c);
            c = new Course() { Code = "COMP214", Name = "Advanced Database" };
            courses.Add(c.Code, c);
            c = new Course() { Code = "COMP124", Name = "Introduction to Databases" };
            courses.Add(c.Code, c);
            return courses;
        }
        public static SortedList<string, Course> CreateSortedList()
        {
            SortedList<string, Course> courses = new SortedList<string, Course>();
            Course c = new Course() { Code = "COMP301", Name = "Operating Systems" };
            courses.Add(c.Code, c);
            c = new Course() { Code = "COMP123", Name = "Programming II" };
            courses.Add(c.Code, c);
            c = new Course() { Code = "COMP120", Name = "Software Engineering Fundamentals" };
            courses.Add(c.Code, c);
            c = new Course() { Code = "COMP225", Name = "Systems Analysis and Design" };
            courses.Add(c.Code, c);
            c = new Course() { Code = "COMP305", Name = "Game Programming I" };
            courses.Add(c.Code, c);
            c = new Course() { Code = "COMP100", Name = "Programming I" };
            courses.Add(c.Code, c);
            c = new Course() { Code = "COMP396", Name = "Game Programming II" };
            courses.Add(c.Code, c);
            c = new Course() { Code = "COMP392", Name = "Advanced Graphics" };
            courses.Add(c.Code, c);
            c = new Course() { Code = "COMP212", Name = "Programming III" };
            courses.Add(c.Code, c);
            c = new Course() { Code = "COMP228", Name = "Advanced Java Programming" };
            courses.Add(c.Code, c);
            c = new Course() { Code = "COMP214", Name = "Advanced Database" };
            courses.Add(c.Code, c);
            c = new Course() { Code = "COMP124", Name = "Introduction to Databases" };
            courses.Add(c.Code, c);
            return courses;
        }
        public static Stack<string> CreateStack()
        {
            return new Stack<string>("red orange yellow green blue indigo violet".Split());
        }
        public static Queue<string> CreateQueue()
        {
            return new Queue<string>("red orange yellow green blue indigo violet".Split());
        }
        public static LinkedList<string> CreateLinkedList()
        {
            return new LinkedList<string>("the brown fox jumps over the dog".Split());
        }
    }
    public class Course //: IComparable<Course>
    {
        public string Code, Name;

        public override string ToString()
        {
            return string.Format("{0} - {1}", Code, Name);
        }

        //public int CompareTo(Course other)
        //{
        //    return this.Code.CompareTo(other.Code); //ascending
        //    //return other.Code.CompareTo(this.Code); //descending
        //}

        //public override bool Equals(object obj)
        //{
        //    return ((Course)obj).Code == Code;
        //}
    }
}
