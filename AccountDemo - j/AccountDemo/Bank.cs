using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDemo
{
    static class Bank 
    {
        private static List<Account> accounts = new List<Account>();
        private static List<Person> persons = new List<Person>();

        static Bank()
        {
            InitializeAccounts();
            //initialize accounts was never called but needs to for the program to run. i have swapped it in in place of create persons and create accounts
            //CreatePersons();
            //CreateAccounts();
        }

        private static void CreatePersons()
        {

            persons = new List<Person>()
            {
            new Person("Narendra", "1234-5678"),
            new Person("Ilia", "2345-6789"),
            new Person("Tom", "3456-7890"),
            new Person("Syed", "4567-8901"),
            new Person("Arben", "5678-9012"),
            new Person("Patrick", "6789-0123"),
            new Person("Yin", "7890-1234"),
            new Person("Hao", "8901-2345"),
            new Person("Jake", "9012-3456")
            };
        }

        private static void CreateAccounts()
        {
            accounts = new List<Account>
            {
            new VisaAccount(),              //VS-100000
            new VisaAccount(550, -500),     //VS-100001
            new SavingAccount(5000),        //SV-100002
            new SavingAccount(),            //SV-100003
            new CheckingAccount(2000),      //CK-100004
            new CheckingAccount(1500, true) //CK-100005
            };

        }

        private static void InitializeAccounts()
        {
            CreateAccounts();
            CreatePersons();

            accounts[0].AddUser(persons[0]);
            accounts[0].AddUser(persons[1]);
            accounts[0].AddUser(persons[2]);
           
            accounts[1].AddUser(persons[3]);
            accounts[1].AddUser(persons[4]);
            accounts[1].AddUser(persons[2]);
           
            accounts[2].AddUser(persons[0]);
            accounts[2].AddUser(persons[5]);
            accounts[2].AddUser(persons[6]);
           
            accounts[3].AddUser(persons[5]);
            accounts[3].AddUser(persons[6]);
           
            accounts[4].AddUser(persons[5]);
            accounts[4].AddUser(persons[7]);
            accounts[4].AddUser(persons[8]); 
            
            accounts[5].AddUser(persons[5]);
            accounts[5].AddUser(persons[6]);
        }

        public static void PrintAccounts()
        {
            foreach (Account acc in accounts)
            {
                Console.WriteLine(acc);
            }
        }

        public static void PrintPersons()
        {
            foreach (Person per in persons)
            {
                Console.WriteLine(per);
            }
        }

        public static Person GetPerson(string name)
        {
            bool isfound = false;
            Person foundPerson = persons[0];
            foreach (Person per in persons)
            {
                //stores person if names match
                if (per.Name == name)
                {
                    isfound = true;
                    foundPerson = per;
                    break;
                }
            }
            //Done searching list. Now return if person if found
            if (!isfound)
            {
                throw new AccountException(AccountException.NAME_NOT_ASSOCIATED_WITH_ACCOUNT);

            }
            else {
                return foundPerson;
            }

        }

        public static Account GetAccount(string number)
        { 
            bool isfound = false;
            Account foundAcc = accounts[0];
            foreach (Account acc in accounts)
            {
                //stores account if number matches
                if (acc.Number == number)
                {
                    isfound = true;
                    foundAcc = acc;
                    break;
                }
            }
            //Done searching list. Now return if account is found
            if (!isfound)
            {
                throw new AccountException(AccountException.ACCOUNT_DOES_NOT_EXIST);
            }
            else
            {
                return foundAcc;
            }
        }

        

    }
}
