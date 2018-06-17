using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class CheckingAccount : Account
    {
        private static double INTEREST_RATE = 0.005;
        private static double COST_PER_TRANSACTION = 0.65;
        private bool hasOverdraft;

        public CheckingAccount(double balance = 0, bool hasOverdraft = false)
            : base("CK", balance)
        {
            this.hasOverdraft = hasOverdraft;
        }

        
        public new void Deposit(double amount, Person person)
        {
            //if (IsHolder(person.Name))
                base.Deposit(amount, person);
        }

        public void Withdraw(double amount, Person person)
        {
            if (!IsHolder(person.Name))
                throw new AccountException(AccountException.NAME_NOT_ASSOCIATED_WITH_ACCOUNT, person.Name);
            if (!person.IsAuthenticated)
                throw new AccountException(AccountException.USER_NOT_LOGGED_IN, person.Name);
            if (Balance < amount && !hasOverdraft)
                throw new AccountException(AccountException.NO_OVERDRAFT, Number);

            base.Deposit(-amount, person);
        }

        public override void PrepareMonthlyReport()
        {
            double serviceCharge = transactions.Count * COST_PER_TRANSACTION;
            double interest = Balance * INTEREST_RATE / 12;
            Balance = Balance + interest - serviceCharge;
            transactions.Clear();
        }
    }
}
