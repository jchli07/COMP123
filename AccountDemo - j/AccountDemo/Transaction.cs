using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDemo
{
    class Transaction
    {
        public readonly string AccountNumber;
        public readonly double Amount;
        public readonly double EndBalance;
        public readonly Person Originator;
        public readonly DateTime Time;

        public Transaction(string accountNumber, double amount, double endBalance, Person person, DateTime time) {
            AccountNumber = accountNumber;
            Amount = amount;
            EndBalance = endBalance;
            Originator = person;
            Time = time;
        }

        public override string ToString()
        {
            string operation = string.Format("{0}",Amount >0? "Deposit":"Withdrawal");
            string output = string.Format("AN: {0}.  {1}: {2:c}  Balance after transaction: {3:c}. Person: {4}. Time: {5}", AccountNumber,operation,Math.Abs(Amount),EndBalance,Originator.Name,Time, Amount);
            return output;
        }


    }
}
