using System;
using System.Collections.Generic;
using System.Xml.Serialization;     //needed for serialization
using System.Xml;                   //needed for serialization
using System.IO;

//must add a reference to System.Web.Extensions
using System.Web.Script.Serialization; //necessary for json serialization

namespace FileIODemo
{
    //the class to serialize
    [Serializable]
    public class Student
    {
        public string Name { get; set; }
        public bool Fulltime { get; set; }
        public string program;
        public string sin;
        public Student() { }
        public Student(string name, bool fulltime, string program, string sin)
        {
            Name = name;
            Fulltime = fulltime;
            this.program = program;
            this.sin = sin;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //WriteTextFile("boo.txt");
            //ReadTextFile("boo.txt");
            //WriteBinaryFile("boo.bin");
            //ReadBinaryFile("boo.bin");
            //SerializeOneStudent("student.xml");
            //DeSerializeOneStudent("student.xml");
            //SerializeListOfStudents("students.xml");
            //DeSerializeListOfStudents("students.xml");
            //SerializeOneStudentJson("student.json");
            //DeserializeOneStudentJson("student.json");
            //DisplayDrives();
            DisplayDirectories();
            SaveOneStudentAsJson("student.json");
        }
        static void SaveOneStudentAsJson(string filename)
        {
            Student s = new Student("wifang", true, "gaming", "123");
            using (StreamWriter writer = new StreamWriter(filename))
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                writer.WriteLine(serializer.Serialize(s));
            }
        }
        static void RetrieveOneStudentFromJson(string filename)
        {
            Student s;
            using (StreamReader reader = new StreamReader(filename))
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                s = serializer.Deserialize<Student>(reader.ReadToEnd());
            }
        }

        static void DisplayDirectories()
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(@"c:\");

                DirectoryInfo[] dirs = di.GetDirectories();
                Console.WriteLine("The number of directories is {0}.", dirs.Length);

                foreach (DirectoryInfo diNext in dirs)
                {
                    Console.WriteLine("The number of files in {0} is {1}", diNext,
                        diNext.GetFiles().Length);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }
       
        static void DisplayDrives()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                Console.WriteLine("Drive {0}", d.Name);
                Console.WriteLine("  Drive type: {0}", d.DriveType);
                if (d.IsReady == true)
                {
                    Console.WriteLine("  Volume label: {0}", d.VolumeLabel);
                    Console.WriteLine("  File system: {0}", d.DriveFormat);
                    Console.WriteLine(
                        "  Available space to current user:{0, 15} bytes",
                        d.AvailableFreeSpace);

                    Console.WriteLine(
                        "  Total available space:          {0, 15} bytes",
                        d.TotalFreeSpace);

                    Console.WriteLine(
                        "  Total size of drive:            {0, 15} bytes ",
                        d.TotalSize);
                }
            }
        }
        
        static void DeserializeOneStudentJson(string filename)
        {
            Student student;
            using (StreamReader reader = new StreamReader(filename))
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                student= serializer.Deserialize<Student>(reader.ReadToEnd());
            }
            Console.WriteLine("{0} {1} {2} {3}",
                student.Name, student.program, student.Fulltime, student.sin);
            Console.ReadLine();
        }
        
        static void SerializeOneStudentJson(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                Student student = new Student("Abdul", false, "Health", "126");
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                writer.WriteLine(serializer.Serialize(student));
            }
        }

        static void DeSerializeListOfStudents(string filename)
        {
            List<Student> students;
            using (TextReader reader = new StreamReader(filename))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
                students = (List<Student>)serializer.Deserialize(reader);
            }
            foreach (var o in students)
            {
                Console.WriteLine("{0} {1} {2} {3}", o.Name, o.program, o.Fulltime, o.sin);
            }
        }
        
        static void SerializeListOfStudents(string filename)
        {
            List<Student> students = new List<Student>(){
                new Student("David", true, "Gaming", "123"),
                new Student("Imran", false, "Gaming", "124"),
                new Student("Vaishali", true, "Software", "125"),
                new Student("Abdul", false, "Health", "126"),
                new Student("Son", true, "Gaming", "127"),
                new Student("Thea", false, "Gaming", "128"),
                new Student("Galiya", true, "Gaming", "129"),
                new Student("Alishan", false, "Gaming", "130")
            };

            using (TextWriter writer = new StreamWriter(filename))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
                serializer.Serialize(writer, students);
            }
        }

        static void DeSerializeOneStudent(string filename)
        {
            Student o;
            using (TextReader reader = new StreamReader(filename))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Student));
                o = (Student)serializer.Deserialize(reader);
            }
            Console.WriteLine("{0} {1} {2} {3}", o.Name, o.program, o.Fulltime, o.sin);
        }

        static void SerializeOneStudent(string filename)
        {
            Student studObj = new Student("David", true, "Interactive Gaming", "very bad");
            using (TextWriter writer = new StreamWriter(filename))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Student));
                serializer.Serialize(writer, studObj);
            }
        }

        static void ReadBinaryFile(string filename)
        {
            float fVar;
            string sVar;
            int iVar;
            bool bVar;
            using (BinaryReader reader =
                new BinaryReader(File.Open(filename, FileMode.Open)))
            {
                fVar=reader.ReadSingle();
                sVar = reader.ReadString();
                iVar = reader.ReadInt32();
                bVar = reader.ReadBoolean();
            }
            Console.WriteLine(" {0}", fVar);
            Console.WriteLine(" {0}", sVar);
            Console.WriteLine(" {0}", iVar);
            Console.WriteLine(" {0}", bVar);
        }
        
        //write binary data to file
        static void WriteBinaryFile(string filename)
        {
            using(BinaryWriter writer = 
                new BinaryWriter(File.Open(filename, FileMode.Create)))
            {

                writer.Write(1.250F);
                writer.Write(@"c:\Temp");
                writer.Write(10);
                writer.Write(true);
            }
        }

        //write text to file
        private static void WriteTextFile(string filename)
        {

            using (TextWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("File created on {0}", DateTime.Now.ToLongDateString());
                for (int i = 1; i <= 10; i++)
                {
                    writer.WriteLine("{0,3} x {1,3} = {2,3}", 12, i, i * 12);
                }

                writer.WriteLine(1.250F);
                writer.WriteLine(@"c:\Temp");
                writer.WriteLine(10);
                writer.WriteLine(true);
            }
        }
        
        //read the test file
        static void ReadTextFile(string filename)
        {
            using (TextReader reader = new StreamReader(filename))
            {
                string line = "";
                while((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
