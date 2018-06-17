using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculatorDemo
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
            int first, second, result;
            first = Convert.ToInt32(txtfirst.Text);
            second = Convert.ToInt32(txtsecond.Text);
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

            txtresult.Text = result.ToString();
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
    }
}
