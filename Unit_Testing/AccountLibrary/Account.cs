using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLibrary
{
    public class Account
    {
        private static double LIMIT = 250;
        public static string LIMIT_EXCEEDED = "ERROR: Withdrawal Amount exceeds limit";
        public static string INSUFFICIENT = "ERROR: Insufficient Funds";
        
        public string Name { get; private set; }
        public double Balance { get; private set; }
        private bool frozen;
        public Account(string name, double balance = 0)
        {
            Name = name;
            Balance = balance;
        }
        public void Withdraw(double amount)
        {
            if (amount > LIMIT)
                throw new ArgumentOutOfRangeException(LIMIT_EXCEEDED);
            if (amount > Balance)
                throw new ArgumentOutOfRangeException(INSUFFICIENT);
            Balance += amount; //incorrect code
        }
        public override string ToString()
        {
            return string.Format("{0} {1:c} {2}", Name, Balance, frozen ? "Frozen": "");
        }
    }
}
