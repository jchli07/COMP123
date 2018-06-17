using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDemo
{
    class Person
    {
        // Private fields
        private string password;

        // Public fields
        public readonly string SIN;  

        // Properties
        public bool IsAuthenticated { get; private set; }
        public string Name { get; private set; }

        // Methods
        public Person(string name, string sin)
        {
            SIN = sin;
            Name = name;

            
            password = sin.Substring(0,3);


        }




        public void Login(string password)
        {
            if (this.password == password)
            {
                IsAuthenticated = true;
            }
            else
            {
                //IsAuthenticated = false; //For added security, if password is incorrect, set IsAuthenticated to false
                throw new AccountException(AccountException.PASSWORD_INCORRECT);
            }
        }

        public void Logout()
        {
            IsAuthenticated = false;
        }

        public override string ToString()
        {
            return string.Format("{0} is {1}", Name, IsAuthenticated ? "authenticated" : "Not authenticated");
        }
    }
}
