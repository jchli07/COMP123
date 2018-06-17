using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using System.Web.Script.Serialization;

namespace AtomDemo
{
    [Serializable]
    public class Atom
    {
        public string name;
        public string symbol;
        public int proton;
        public int neutron;
        public double weight;

        public Atom(string name, int proton, int neutron, double weight, string symbol)
        {
            this.name = name;
            this.symbol = symbol;
            this.proton = proton;
            this.neutron = neutron;
            this.weight = weight;

        }
        public Atom()
        { 
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", name, proton, neutron, weight, symbol);
        }
        public static Atom Parse(string line)
        {
            string[] xline = line.Split(' ');

            if (xline.Length > 5)
                throw new Exception("ERROR: Not enough variables!");

            Atom a = new Atom();

            string newname = xline[0];
            int newproton = Convert.ToInt32(xline[1]);
            int newneutron = Convert.ToInt32(xline[2]);
            double newweight = Convert.ToDouble(xline[3]);
            string newsym = xline[4];

            return a;
        }

        public static void SerializeOneElement(string filename)
        {
            Atom element = new Atom("Hydrogen", 1, 0, 1.0079, "H");
            using (TextWriter writer = new StreamWriter(filename))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Atom));
                serializer.Serialize(writer, element);
            }
        }

        public static void SerializeListOfElements(string filename)
        {
            List<Atom> elements;
        
            using (TextWriter writer = new StreamWriter(filename))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Atom>));
                serializer.Serialize(writer, elements);
            }
        }

        public static void SerializeOneElementJson(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                Atom element = new Atom("Hydrogen", 1, 0, 1.0079, "H");
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                writer.WriteLine(serializer.Serialize(element));
            }
        }
    }

}
