using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.IO;

namespace Week5._5Demo
{
    class student
    {
        public string Name { get; set; }
        public bool IsFullTime { get; set; }
        public string program;
        public string sin;

        public student(string Name, bool IsFullTime, string program, string sin)
        {
            this.Name = Name;
            this.IsFullTime = IsFullTime;
            this.program = program;
            this.sin = sin;
        }
    }
    class program
    {
        static void WriteXmlFile(string filename)
        {
            student obj = new student("Johanan", true, "gamimg", "123");
            using(StreamWriter writer = new StreamWriter(filename))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(student));
                serializer.Serialize(writer, obj);
            }
        }
        static void Main(string[] args)
        {
            //WriteTextFile("boo.txt");
            ReadTextFile("boo.txt");
        }
        static void ReadBinaryFile(string filename)
        {
            bool bVar;
            double dVar;
            string sVar;
            int iVar;

            using (BinaryReader reader = new BinaryReader(File.Open(filename, FileMode.Open)))
            {
                bVar = reader.ReadBoolean();
                dVar = reader.ReadDouble();
                sVar = reader.ReadString();
                iVar = reader.ReadInt32();
            }
            Console.WriteLine("{0}", bVar);
            Console.WriteLine("{0}", dVar);
            Console.WriteLine("{0}", sVar);
            Console.WriteLine("{0}", iVar);
        }
        static void WriteBinaryFile(string filename)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(filename, FileMode.Create)))
            {
                writer.Write(true);
                writer.Write(Math.PI);
                writer.Write("devin is evil");
                writer.Write(100);
            }
        }
        static void ReadTextFile(string filename)
        {
            using (TextReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                    Console.WriteLine(line);
            }
        }
        static void WriteTextFile(string filename)
        {
            using (TextWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("File created on {0}", DateTime.Now.ToLongTimeString());
                for (int i = 1; i <= 10; i++)
                    writer.WriteLine("12 x {0} = {1}", i, i * 12);
            }

        }
    }
}
