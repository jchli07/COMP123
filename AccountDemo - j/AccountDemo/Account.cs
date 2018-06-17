using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDemo
{
    abstract class Account
    {
        //fields
        public readonly List<Person> holders = new List<Person>();
        public readonly List<Transaction> transactions = new List<Transaction>();
        public readonly string Number;
        private static int LAST_NUMBER = 100000;

        //properties
        public double Balance { get; protected set; }
        public double LowestBalance { get; protected set; }

        public Account(string type, double balance) {
            Balance = balance;
            LowestBalance = balance;

            Number = type + LAST_NUMBER.ToString();
            
            LAST_NUMBER++;
        }

        public void AddUser(Person person) {
            holders.Add(person);
        }

        public void Deposit(double amount, Person person){
            Balance +=amount;
            if (Balance < LowestBalance)
            {
                //lowest balance only updates if lower then new balance
                LowestBalance = Balance;
            }

            Transaction transaction = new Transaction(Number, amount, Balance, person, DateTime.Now);
            transactions.Add(transaction);

        }

        public bool IsHolder(string name){
            bool isFound = false;
            foreach(Person p in holders){
                if(p.Name == name){
                    isFound = true;
                }
            }
            return isFound;
        }

        public abstract void PrepareMonthlyReport();

        public override string ToString() {
            string output = "Account: ";
            output += Number;
            output += "\nHolders:\n";
            foreach(Person p in holders){
                output +="     "+ p;
                output += "\n";
            }

            string bal = string.Format("{0:c}",Balance);
            output +="Balance : "+bal;
            output += "\nTransactions:\n";
            foreach (Transaction t in transactions){
                output +="      " +t;
                output += "\n";
            }
            
            return output;
        }

    }
}
