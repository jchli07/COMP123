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
    public partial class AccountDetailsForm : Form
    {
        Dictionary<string, Person> holders = new Dictionary<string, Person>();
        Account account;
        Person selectedPerson;
        bool filter = false;
        public AccountDetailsForm(Account a)
        {
            account = a;
            InitializeComponent();
            InitializeGUI();

        }

        void InitializeGUI() {
            lblBalance.Text = account.Balance.ToString();
            lblNumber.Text = account.Number;
            lblType.Text = account.GetType().ToString().Substring(account.GetType().ToString().IndexOf('.')+1);
            UpdateGridView();

            foreach (Person p in account.holders) {
                holders.Add(p.Name, p);
            }
            
            lstHolders.DataSource = holders.Keys.ToList();
        }

        void UpdateGridView() {
            List<Transaction> transactions = new List<Transaction>();
            
            if (filter)
            {
                foreach (Transaction t in account.transactions) {
                    if (t.Originator == selectedPerson) {
                        transactions.Add(t);
                    }
                }
            }
            else {
                transactions = account.transactions;
            }
            dgvTransactions.DataSource = null;
            dgvTransactions.DataSource = transactions;

        }

        private void lstHolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPerson = holders[lstHolders.SelectedValue.ToString()];
            UpdateGridView();
        }

        private void chkFilter_CheckedChanged(object sender, EventArgs e)
        {
            
            filter = chkFilter.Checked;
            UpdateGridView();
            
        }
    }
}
