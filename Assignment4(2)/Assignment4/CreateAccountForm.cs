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
    public partial class CreateAccountForm : Form
    {
        List<string> AccountTypes = new List<string> { "Saving Account","Checking Account", "Visa Account"};
        bool hasOverdraft = false;
        Account account;
        string type = "";
        double balance = 0;

        Form1 parent;

        string selectedPerson = "";
        string selectedHolder = "";

        Dictionary<string, Person> allPeople = new Dictionary<string, Person>();
        Dictionary<string, Person> holders = new Dictionary<string, Person>();


        public CreateAccountForm(Form1 f1)
        {
            parent = f1;
            InitializeComponent();
            foreach (Person p in Bank.persons) {
                allPeople.Add(p.Name, p);
            }

            lstPeople.DataSource = allPeople.Keys.ToList();
            cmbType.DataSource = AccountTypes;
        }


        private void lstPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPerson = lstPeople.SelectedValue.ToString();
        }

        private void lstHolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedHolder = lstHolders.SelectedValue.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (holders.Count > 0)
            {

                
                switch (cmbType.SelectedValue.ToString()) {
                    case "Visa Account":
                        account = new VisaAccount(double.Parse(txtBalance.Text));
                        break;
                    case "Saving Account":
                        account = new SavingAccount(double.Parse(txtBalance.Text));
                        break;
                    default:
                        account = new CheckingAccount(double.Parse(txtBalance.Text), hasOverdraft);
                        break;
                }

                foreach(Person p in holders.Values) {
                    account.AddUser(p);
                }

                Bank.accounts.Add(account);
                parent.InitializeGUI();
                this.Close();
            }
            else {
                MessageBox.Show("You must add at least one holder.");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (allPeople.Count > 0)
            {
                holders.Add(selectedPerson, allPeople[selectedPerson]);
                allPeople.Remove(selectedPerson);

                //lstHolders = null;
                //lstPeople = null;
                lstPeople.DataSource = allPeople.Keys.ToList();
                lstHolders.DataSource = holders.Keys.ToList();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (holders.Count > 0)
            {
                allPeople.Add(selectedHolder, holders[selectedHolder]);
                holders.Remove(selectedHolder);


                lstPeople.DataSource = allPeople.Keys.ToList();
                lstHolders.DataSource = holders.Keys.ToList();
            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedValue.ToString() == "Visa Account")
            {
                chkOverdraft.Enabled = true;
            }
            else {
                chkOverdraft.Enabled = false;
            }           
        }

        private void chkOverdraft_CheckedChanged(object sender, EventArgs e)
        {
            hasOverdraft = chkOverdraft.Checked;
        }
    }
}
