//Devin Young
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDemo
{
    class VisaAccount : Account
    {
        private double creditLimit;
        public double INTEREST_RATE = 0.1995;

        public VisaAccount(double balance = 0, double creditLimit = 1200)
            :base ("VS-", balance)
        {
            this.creditLimit = creditLimit;
        }

        public void DoPayment(double amount, Person person)
        {
            base.Deposit(amount, person);   
        }

        public void DoPurchase(double amount, Person person)
        {

            if (!holders.Contains(person))
            {
                throw new AccountException(AccountException.NAME_NOT_ASSOCIATED_WITH_ACCOUNT);
            }
            else if (!person.IsAuthenticated) {
                throw new AccountException(AccountException.USER_NOT_LOGGED_IN);
            }
            else if (Balance - amount < creditLimit)
            {
                throw new AccountException(AccountException.CREDIT_LIMIT_HAS_BEEN_EXCEEDED);
            } else {
                Deposit(amount * -1, person);
            }
            
        }
        public override void PrepareMonthlyReport()
        {
            INTEREST_RATE = (LowestBalance * INTEREST_RATE) / 12;

            Balance -= INTEREST_RATE;

            transactions.Clear();
        }
        
    }
}
