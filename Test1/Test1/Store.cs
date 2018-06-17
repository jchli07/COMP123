using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;     
using System.Xml;                   
using System.IO;
using System.Web.Script.Serialization;

//Name: James Li
//Student ID: 300588427
namespace Test1
{
    class Store
    {
        List<Parts> parts = new List<Parts>();
        string Number { get; private set; }
        string PostalCode { get; private set; }

        public Store(string number, string postalCode)
        {
            Number = number;
            PostalCode = postalCode;
        }

        public void InsertPart(Parts part) 
        {
            parts.Add(part);
        }

        public void RemovePart(string partId) 
        { 
            for (int i = 0; i < parts; i++)

                if (Parts.partId[i] == partId )
                {
                   RemoveAt(i);
                }
                if (Parts.partId[i] != partId)
                {
                    throw new Exception("ERROR - Does Not Exist!");
                }

           
        }
        private string GetParts()
        {
            foreach (Parts p in parts)
            {
                if (p.parts == GetParts)
                    return p;
            }
            
        }
        public override string ToString()
        {
            return string.Format("{0} {1}", Number, PostalCode);
        }

        public void SaveAsXml(string filename)
        {
            using (TextWriter writer = new StreamWriter(filename))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Parts>));
                serializer.Serialize(writer, parts);
            }
 
        }
        


    }
    
}
