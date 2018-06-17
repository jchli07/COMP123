using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsDemo
{
    class Account
    {
        private int CURRENT_ACCOUNT_NUMBER;
        public string Number;
        private const int TRANSIT_NUMBER = 314;

        public double Balance { get; private set; }
        public List<string> Names { get; private set; }

        public Account(double Balance, string Names)
        {
            this.Names = new List<string>();
            this.Balance = Balance;
        }

        public override string ToString()
        {
            return string.Format("{0}{1}", Balance, Names);
        }

        public static Account()
        {
            
        }

    }
}
