using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiElementDemo
{
    public partial class Form1 : Form
    {
        Dictionary<string, Element> elements; 
        public Form1()
        {
            InitializeComponent();
            InitializeGui();
        }

        private void InitializeGui()
        {
            elements = new Dictionary<string, Element>();
            foreach (var e in Element.GetElements())
            {
                elements.Add(e);
            }
            lstelement.DataSource = new List<string>(elements.Keys);
        }
    }
}
