using System;
using System.Collections.Generic;

namespace Assignment4
{
    public abstract class Account
    {
        private static int LAST_NUMBER = 100000;
        public readonly string Number;
        public readonly List<Person> holders = new List<Person>();
        public readonly List<Transaction> transactions = new List<Transaction>();

        public double Balance { get; protected set; }
        public double LowestBalance { get; private set; }

        public Account(string type, double balance)
        {
            Balance = balance;
            LowestBalance = balance;
            Number = type + "-" + LAST_NUMBER++;
        }
        public Account(string type, double balance, List<Transaction> transactions)
        {
            Balance = balance;
            LowestBalance = balance;
            this.transactions = transactions;
            Number = type + "-" + LAST_NUMBER++;
        }
        public void AddUser(Person person)
        {
            holders.Add(person);
        }

        public void Deposit(double amount, Person person)
        {
            Balance += amount;
            if (Balance < LowestBalance)
                LowestBalance = Balance;
            Transaction t = new Transaction(Number, amount, Balance, person, DateTime.Now);
            transactions.Add(t);
        }

        public bool IsHolder(string name)
        {
            foreach (Person p in holders)
                if (p.Name == name)
                    return true;

            return false;
        }

        public override string ToString()
        {
            string names = string.Empty;
            foreach (Person p in holders)
                names += p.Name + " ";
            string activities = "\nActivities: ";
            foreach (Transaction t in transactions)
                activities += "\n  " + t;

            return string.Format("\n{0} {1:c} {2}{3}", Number, Balance, names, activities);
        }

        public abstract void PrepareMonthlyReport();
    }
}
