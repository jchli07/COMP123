using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{

    public class VisaAccount : Account
    {
        private static double INTEREST_RATE = 19.99;
        private double creditLimit;

        public VisaAccount(double balance = 0, double creditLimit = -1200)
            : base("VS", balance)
        {
            this.creditLimit = creditLimit;
        }

        public void DoPayment(double amount, Person person)
        {
            base.Deposit(amount, person);
        }

        public void DoPurchase(double amount, Person person)
        {
            if (!IsHolder(person.Name))
                throw new AccountException(AccountException.NAME_NOT_ASSOCIATED_WITH_ACCOUNT, person.Name);
            if (!person.IsAuthenticated)
                throw new AccountException(AccountException.USER_NOT_LOGGED_IN, person.Name);
            if (Balance - amount < creditLimit)
                throw new AccountException(AccountException.CREDIT_LIMIT_HAS_BEEN_EXCEEDED, Number);

            base.Deposit(-amount, person);
        }

        public override void PrepareMonthlyReport()
        {
            double interest = LowestBalance * INTEREST_RATE / 12;
            Balance = Balance - interest;
            transactions.Clear();
        }
    }
}
