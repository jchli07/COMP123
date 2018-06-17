using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ElementsDemo
{
    public partial class Form1 : Form
    {
        List<Elements> elements;
        public Form1()
        {
            InitializeComponent();
            IntializeGUI();
        }
        private void IntializeGUI()
        {
            elements = Elements.ReadTextFile(@"P:\NPERSH\COMP123\Common\Elements.txt");

            dgvElements.DataSource = elements;


            

           // elements.Add(new Elements(txtName.Text,txtNeutron.Text, txtProton.Text, txtSymbol.Text, txtSymbol.Text));

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            elements.Add(new Elements(txtName.Text, Convert.ToInt32(txtProton.Text), Convert.ToInt32(txtNeutron.Text), Convert.ToDouble(txtWeight.Text), txtSymbol.Text));
            dgvElements.DataSource = null;
            dgvElements.DataSource = elements;
        }

 
        private void btnModify_Click(object sender, EventArgs e)
        {
            dgvElements.DataSource = null;
            try
            {
                bool isFound = false;

                for (int i = 0; i < elements.Count; i++)
                {
                    if (txtName.Text == elements[i].Name)
                    {
                        elements[i].Proton = Convert.ToInt32(txtProton.Text);
                        elements[i].Neutron = Convert.ToInt32(txtNeutron.Text);
                        elements[i].Weight = Convert.ToDouble(txtNeutron.Text);
                        elements[i].Symbol = txtSymbol.Text;
                        isFound = true;
                    }

                    if (!isFound)
                    {
                        throw new Exception("Please enter a valid Element!");
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvElements.DataSource = elements;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvElements.DataSource = null;

            try
            {
                bool isFound = false;

                for (int i = 0; i < elements.Count; i++)
                {
                    if (txtName.Text == elements[i].Name)
                    {
                        elements.RemoveAt(i);
                        isFound = true;
                    }
                }

                if (!isFound)
                {
                    throw new Exception("Please enter a valid Element!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dgvElements.DataSource = elements;
        }


    }
}
