using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDemo
{
    class CheckingAccount : Account
    {
        double COST_PER_TRANSACTION = 0.05;
        double INTEREST_RATE = 0.005;
        bool hasOverdraft;

        public CheckingAccount(double balance = 0, bool hasOverdraft = false)
            :base ("CK-", balance)
        {
            this.hasOverdraft = hasOverdraft;
        }

        public new void Deposit(double amount, Person person)
        {
            base.Deposit(amount, person);
        }

        public void Withdraw(double amount, Person person)
        {
            if (!base.holders.Contains(person))
            {
                throw new AccountException(AccountException.NAME_NOT_ASSOCIATED_WITH_ACCOUNT);
            }
            else if (!person.IsAuthenticated)
            {
                throw new AccountException(AccountException.USER_NOT_LOGGED_IN);
            }
            else if (base.Balance < amount && !hasOverdraft)//added not has overdraft to fix this
            {
                throw new AccountException(AccountException.NO_OVERDRAFT);
            }
            else
            {
                base.Deposit(amount*-1, person);
            }
        }

        public override void PrepareMonthlyReport()
        {
            double Interest;
            double SC = base.transactions.Count * COST_PER_TRANSACTION;
            Console.WriteLine(SC);
            Interest = (Balance * INTEREST_RATE) / 12;
            Balance = (Interest + Balance) - SC;
            transactions.Clear();
        }
    }
}
