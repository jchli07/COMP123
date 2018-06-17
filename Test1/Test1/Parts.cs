using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: James Li
//Student ID: 300588427
namespace Test1
{
    class Parts
    {
        private static int CURRENT_NUMBER = 100000;

        public bool inStock;
        public string name;
        public string partId;
        public double price;
        public int quantity;

        public Parts(string name, double price, int quantity = 1, bool isBackordered = false)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            inStock = isBackordered;
            partId = Convert.ToString(CURRENT_NUMBER);
            CURRENT_NUMBER++;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", name, price, quantity, inStock);
        }
    }
    
}
