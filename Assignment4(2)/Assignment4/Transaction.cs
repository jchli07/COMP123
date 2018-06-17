using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public sealed class Transaction
    {
        public  string AccountNumber { get; }
        public double Amount { get; }
        public double EndBalance { get; }
        public Person Originator { get; }
        public DateTime Time { get; }

        public Transaction(string accountNumber, double amount, double 
            endBalance, Person person, DateTime time)
        {
            AccountNumber = accountNumber;
            Amount = amount;
            EndBalance = endBalance;
            Originator = person;
            Time = time;
        }

        public override string ToString()
        {
            if(Amount < 0)
                return string.Format("{0} withdraw {1:c} on {2}", Originator.Name, -Amount, Time.ToShortTimeString());
            return string.Format("{0} deposit {1:c} on {2}", Originator.Name, Amount, Time.ToShortTimeString());
        }
    }
}
