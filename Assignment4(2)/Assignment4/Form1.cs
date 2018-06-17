using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        Person currentUser;
        Account selectedAccount;

        Dictionary<string, Person> bankUsers = new Dictionary<string, Person>();
        Dictionary<string, Account> bankAccounts = new Dictionary<string, Account>();


        //forms
        AccountDetailsForm adf;
        CreateAccountForm acf;
        CreateUserForm cuf;

        public static void Debug(string text) {
            MessageBox.Show(text);
        }

        public Form1()
        {
            InitializeComponent();
            InitializeData();
            InitializeGUI();
        }

        public void InitializeGUI() {
            bankUsers = new Dictionary<string, Person>();
            bankAccounts = new Dictionary<string, Account>();
            //user drop down
            foreach (Person p in Bank.persons) {
                bankUsers.Add(p.Name, p);
            }
            cmbUsers.DataSource = bankUsers.Keys.ToList();

            //accounts listbox
            foreach (Account a in Bank.accounts) {
                bankAccounts.Add(a.Number, a);
            }
            lstAccounts.DataSource = bankAccounts.Keys.ToList();


        }

        void InitializeData()
        {
            Person p0, p1, p2, p3, p4, p5, p6, p7, p8;
            p0 = Bank.GetPerson("Narendra");
            p1 = Bank.GetPerson("Ilia");
            p2 = Bank.GetPerson("Tom");
            p3 = Bank.GetPerson("Syed");
            p4 = Bank.GetPerson("Arben");
            p5 = Bank.GetPerson("Patrick");
            p6 = Bank.GetPerson("Yin");
            p7 = Bank.GetPerson("Hao");
            p8 = Bank.GetPerson("Jake");

            p0.Login("123"); p1.Login("234");
            p2.Login("345"); p3.Login("456");
            p4.Login("567"); p5.Login("678");
            p6.Login("789"); p7.Login("890");

            //a visa account
            VisaAccount a = (VisaAccount)Bank.GetAccount("VS-100000");
            a.DoPayment(1500, p0);
            a.DoPurchase(200, p1);
            a.DoPurchase(25, p2);
            a.DoPurchase(15, p0);
            a.DoPurchase(39, p1);
            a.DoPayment(400, p0);
            Console.WriteLine(a);

            a = (VisaAccount)Bank.GetAccount("VS-100001");
            a.DoPurchase(25, p3);
            a.DoPurchase(20, p4);
            a.DoPurchase(15, p2);
            a.DoPayment(400, p0);
            Console.WriteLine(a);

            //a saving account
            SavingAccount b = (SavingAccount)Bank.GetAccount("SV-100002");
            b.Withdraw(300, p0);
            b.Withdraw(32.90, p6);
            b.Withdraw(50, p5);
            b.Withdraw(111.11, p5);
            Console.WriteLine(b);

            b = (SavingAccount)Bank.GetAccount("SV-100003");
            b.Deposit(300, p3);     //ok even though p3 is not a holder
            b.Deposit(32.90, p2);
            b.Deposit(50, p5);
            b.Withdraw(111.11, p5);
            Console.WriteLine(b);

            //a checking account
            CheckingAccount c = (CheckingAccount)Bank.GetAccount("CK-100005");
            c.Deposit(33.33, p7);
            c.Deposit(40.44, p7);
            c.Withdraw(450, p5);
            c.Withdraw(500, p5);
            c.Withdraw(645, p5);
            c.Withdraw(850, p6);
            Console.WriteLine(c);

            c = (CheckingAccount)Bank.GetAccount("CK-100004");
            c.Deposit(33.33, p7);
            c.Deposit(40.44, p7);
            c.Withdraw(150, p5);
            c.Withdraw(200, p7);
            c.Withdraw(645, p7);
            c.Withdraw(350, p5);
        }
            

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( currentUser !=null && currentUser.IsAuthenticated) { currentUser.Logout(); }
            string key = cmbUsers.SelectedValue.ToString();
            currentUser = bankUsers[key];
            setLoginStatus(currentUser.IsAuthenticated);
        }

        void setLoginStatus(bool t) {
            if (t)
            {
                lblAuthentication.Text = "Authenticated";
                lblAuthentication.ForeColor = Color.Green;
                btnLogin.Text = "Logout";
                txtPassword.Text = "";
            }
            else {
                lblAuthentication.Text = "Not Authenticated";
                lblAuthentication.ForeColor = Color.Red;
                btnLogin.Text = "Login";
                txtPassword.Text = "";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (currentUser.IsAuthenticated)
            {
                currentUser.Logout();
            }
            else {
                try{
                    currentUser.Login(txtPassword.Text);
                } catch {
                    MessageBox.Show("Incorrect Password");
                }
            }

            setLoginStatus(currentUser.IsAuthenticated);
            updateWithdrawelDisplay();
        }

        void updateAccountLabels() {
            string accountType = "";

            if (selectedAccount.GetType() == typeof(SavingAccount)) {
                accountType = "Savings";
            } else if (selectedAccount.GetType() == typeof(CheckingAccount)) {
                accountType = "Checking";
            }
            else if (selectedAccount.GetType() == typeof(VisaAccount)){
                accountType = "Visa";
            }
            lblNumber.Text = selectedAccount.Number.ToString();
            lblBalance.Text = selectedAccount.Balance.ToString();
            lblHolderCount.Text = selectedAccount.holders.Count().ToString();
            lblType.Text = accountType;
        }

        void updateWithdrawelDisplay() {
            if (selectedAccount.holders.Contains(currentUser) && currentUser.IsAuthenticated)
            {
                txtWithdraw.Enabled = true;
                btnWithdraw.Enabled = true;
            }
            else {
                txtWithdraw.Enabled = false;
                btnWithdraw.Enabled = false;
            }
        }

        private void lstAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAccount = bankAccounts[lstAccounts.SelectedValue.ToString()];
            updateAccountLabels();
            updateWithdrawelDisplay();


        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (adf != null) {
                adf.Close();
            }
            adf = new AccountDetailsForm(selectedAccount);
            adf.Show();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                selectedAccount.Deposit(double.Parse(txtDeposit.Text), currentUser);
            }
            catch {
                MessageBox.Show("Deposit failed");
            }
            updateAccountLabels();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                selectedAccount.Deposit(double.Parse(txtWithdraw.Text) * -1, currentUser);
            }

            catch {
                MessageBox.Show("withdraw failed");
            }
            updateAccountLabels();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            if (acf != null)
            {
                acf.Close();
            }
            acf = new CreateAccountForm(this);
            acf.Show();
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (cuf != null)
            {
               cuf.Close();
            }
            cuf = new CreateUserForm(this);
            cuf.Show();
        }
    }
}
