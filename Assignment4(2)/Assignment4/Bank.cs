using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public static class Bank
    {
        public static List<Account> accounts { get; private set; }
        public static List<Person> persons { get; private set; }

        static Bank()
        {
            InitializeAccounts();
            Form1.Debug("Accounts have been initialized");
        }

        static void InitializeAccounts()
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

        private static void CreatePersons()
        {
            persons = new List<Person>(){
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
            accounts = new List<Account>{
                new VisaAccount(),              //VS-100000
                new VisaAccount(550, -500),     //VS-100001
                new SavingAccount(5000),        //SV-100002
                new SavingAccount(),            //SV-100003
                new CheckingAccount(2000),      //CK-100004
                new CheckingAccount(1500, true) //CK-100005
            };
        }

        public static Person GetPerson(string name)
        {

            foreach (var p in persons)
            {
                if (p.Name == name)
                    return p;
            }
            throw new AccountException(AccountException.USER_DOES_NOT_EXIST, name);
        }

        public static Account GetAccount(string number)
        {
            foreach (var a in accounts)
            {
                if (a.Number == number) 
                    return a;
            }
            throw new AccountException(AccountException.ACCOUNT_DOES_NOT_EXIST, number);
        }

        public static void PrintAccounts()
        {
            foreach (var a in accounts)
                Console.WriteLine(a);
        }

        public static void PrintPersons()
        {
            foreach (var p in persons)
                Console.WriteLine(p);
        }
    }
}
