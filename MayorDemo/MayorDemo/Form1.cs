using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayorDemo
{
    public partial class Form1 : Form
    {
        List<Mayor> mayors;
        public Form1()
        {
            InitializeComponent();
            mayors = Mayor.GetMayors();
            Gridview.DataSource = mayors;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }


     


       

        
    }
}
