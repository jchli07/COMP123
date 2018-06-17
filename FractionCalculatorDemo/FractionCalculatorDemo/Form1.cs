using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionCalculatorDemo
{
    public partial class Form1 : Form
    {
        string operation = "+";
        public Form1()
        {
            InitializeComponent();
        }
        private void DoCalculation()
        {
            int fN = Convert.ToInt32(firstN.Text);
            int fD = Convert.ToInt32(firstD.Text);
            int sN = Convert.ToInt32(secondN.Text);
            int sD = Convert.ToInt32(secondD.Text);

            Fraction first = new Fraction(fN, fD);
            Fraction second = new Fraction(sN, sD);
            Fraction result;

            switch (operation)
            {
                case "-":
                    result = first - second;
                    break;
                case "*":
                    result = first * second;
                    break;
                case "/":
                    result = first / second;
                    break;
                default:
                    result = first + second;
                    break;
            }

            txtResult1.Text = Convert.ToString(Top);
            txtResult2.Text = Convert.ToString(Bottom);
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            DoCalculation();
        }

        private void ChangedOperation(object sender, EventArgs e)
        {
            RadioButton rButton = (RadioButton)sender;
            operation = rButton.Text;

            //DoCalculation();
        }

        private void txtfirst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                return;
            else
                e.Handled = true;          
        } 


    }
}
