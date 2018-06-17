using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class program
    {
        static void Main()
        {
            //DictionaryDemo();
            //SortedListDemo();
        }

        static void QueueDemo()
        {
            Queue<string> colors = CollectionUtils.CreateQueue();
            foreach (var c in colors)
                Console.WriteLine("{0}", c);

            string gold = "gold";
            colors.Enqueue(gold);
            Console.WriteLine("\n\nAdding {0}", gold);
            foreach (var c in colors)
                Console.WriteLine("{0}", c);

            Console.WriteLine("\nLocating {0} -> {1}". gold colors.Contains(gold));
            gold = "silver";

            
        }


        static void SortedListDemo()
        {
            SortedList<string, Course> courses = CollectionUtils.CreateSortedList();
            Console.WriteLine("All the elements");
            foreach (var pair in courses)
                Console.WriteLine(pair);

            Course c = new Course() { Code = "COMP391", Name = "Introduction to Gaming" };
            courses.Add(c.Code, c);
            Console.WriteLine("All the elements");
            foreach (var pair in courses)
                Console.WriteLine(pair);

            Console.WriteLine("All the keys");
            foreach (var k in courses.Keys)
                Console.WriteLine(k);

            Console.WriteLine("All the values");
            foreach (var v in courses.Values)
                Console.WriteLine(v);

            string prog2 = "COMP123";
            Console.WriteLine(courses[prog2]);

            Console.WriteLine("Removing {0}", prog2);
                courses.Remove(prog2);
            Console.WriteLine("All the elements");
            foreach (var pair in courses)
                Console.WriteLine(pair);

        }


        static void DictionaryDemo()
        {
            Dictionary<string, Course> courses = CollectionUtils.CreateDictionary();
            foreach (var pair in courses)
                Console.WriteLine(pair);

            Console.WriteLine("All the keys");
            foreach (var k in courses.Keys)
                Console.WriteLine(k);

            Console.WriteLine("All the values");
            foreach (var v in courses.Values)
                Console.WriteLine(v);


            string key = "COMP123";
            Console.WriteLine("{0}  -> {1}", key, courses[key]);
            Console.WriteLine("Detecting key {0} {1}", key, courses.ContainsKey(key));

            key = "COMP391";
            Console.WriteLine("Detecting key {0} {1}", key, courses.ContainsKey(key));

            key = "COMP123";
            Course c = courses[key];
            Console.WriteLine(c);

            c = new Course() { Code = "COPM391", Name = "Introduction to Gaming" };
            courses.Add(c.Code, c);
            Console.WriteLine("All the courses");
            foreach (var pair in courses)
                Console.WriteLine(pair);
                
        }

    }
}
