using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Premier_Gui
{
    public partial class Form1 : Form
    {
        Dictionary<string, Premier> premiers;  
        public Form1()
        {
            InitializeComponent();
            InitializeGui();
        }

        private void InitializeGui()
        {
            premiers = new Dictionary<string, Premier>();
            foreach (var p in Premier.GetPremiers())
            {
                premiers.Add(p.GetKey(), p);
            }
            lstPremier.DataSource = new List<string>(premiers.Keys);
        }

        private void DisplayPremier(string key)
        {
            //get the premier object
            Premier p = premiers[key];
            //sets the name label
            lblName.Text = p.name;
            //sets the birth label
            lblBirth.Text = p.birth;
            //sets the office label
            lblOffice.Text = p.range;
            //sets the picture box
            picPremier.Image = Image.FromFile(string.Format("P:\\NPERSH\\COMP123\\images\\{0}.jpg", key));
            MessageBox.Show(@"P:\NPERSH\COMP123\images\" + key+ ".jpg", //what to show
                "Narendra Title",                                       //title of the window
                MessageBoxButtons.OK,                                   //the buttons to show
                MessageBoxIcon.Exclamation);                            //the icons to show
        }


    }
}
