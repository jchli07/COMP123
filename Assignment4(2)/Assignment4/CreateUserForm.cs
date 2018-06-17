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
    public partial class CreateUserForm : Form
    {
        Form1 parent;
        public CreateUserForm(Form1 f1)
        {
            parent = f1;
            InitializeComponent();
        }

        private void CreateUserForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            Person newPerson = new Person(txtName.Text, txtSIN.Text);
            Bank.persons.Add(newPerson);
            parent.InitializeGUI();
            this.Close();
        }
    }
}
