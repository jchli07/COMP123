using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ElementsDemo
{
    class Elements
    {

        public string Name {get;  set;}
        public int Proton { get;  set; }
        public int Neutron { get;  set; }
        public double Weight { get;  set; }
        public string Symbol { get; set; }

        public Elements()
        {

        }
           public Elements(string name, int proton, int neutron, double weight, string symbol)
        {
            Name = name;
            Proton = proton;
            Neutron = neutron;
            Weight = weight;
            Symbol = symbol;

        }
        

        public static List<Elements> ReadTextFile(string filename)
        {
            List<Elements> result = new List<Elements>();
            using (TextReader reader = new StreamReader(filename))
            {
                string line = "" ;
                while ((line = reader.ReadLine()) != null)
                {
                    result.Add(Elements.Parse(line));
                }

            }
            return result;
        }

         public static Elements Parse(string line)
         {
             string[] input = line.Split(' ');

             Elements newElements = new Elements();

                string newName;
                int newProton;
                int newNeutron;
                double newWeight;
                string newSymbol;

             newName = input[0];
                newProton = Convert.ToInt32(input[1]);
                newNeutron = Convert.ToInt32(input[2]);
                newWeight = Convert.ToDouble(input[3]);
                newSymbol = input[4];


                if (input.Length != 5)
                {
                    throw new Exception("Must consist of 5 elements");
                }
                else
                {
                    newElements = new Elements(newName, newProton, newNeutron, newWeight, newSymbol);
                }
                return newElements;
         }
         public override string ToString()
         {
             return string.Format("Name:{0} Proton:{1} Neutron:{2} Weight:{3} Symbol{4}", Name, Proton, Neutron, Weight, Symbol);
         }
          
    }
}
