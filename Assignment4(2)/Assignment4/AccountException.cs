using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class AccountException : Exception
    {
        public const string USER_DOES_NOT_EXIST = "ERROR: The required user does not exist";
        public const string PASSWORD_INCORRECT = "ERROR: User id and password pair does not match";
        public const string NO_OVERDRAFT = "ERROR: This account does not have overdraft";
        public const string ACCOUNT_DOES_NOT_EXIST = "ERROR: The required account number does not exist";
        public const string NAME_NOT_ASSOCIATED_WITH_ACCOUNT = "ERROR: This name is not associated with this account";
        public const string USER_NOT_LOGGED_IN = "ERROR: The user is not logged in";
        public const string CREDIT_LIMIT_HAS_BEEN_EXCEEDED = "ERROR: The credit limit will be exceeded";

        public AccountException() : base() { }
        public AccountException(string message, string data) : base(message + "\n " + data) { }
    }
}
