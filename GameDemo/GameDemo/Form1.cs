using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Name:    James Li
//Student: ID300588427

namespace GameDemo
{
    public partial class Form1 : Form
    {
        List<Event> eventobj;
        public Form1()
        {
            InitializeComponent();
            InitializeGui();
        }

        private void InitializeGui()
        {
            eventobj = Event.CreateEvents();
            dgvEvents.DataSource = eventobj;
        }

        private void Refresh()
        {
            dgvEvents.DataSource = null;
            dgvEvents.Columns["Name"].DisplayIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            eventobj.Add(new Event(txtName.Text, Convert.ToInt32(txtDistance.Text), txtCurrent.Text, EventType.Enum.Parse(txtType.Text), Convert.ToDouble(txtMedal.Text)));
            dgvEvents.DataSource = null;
            dgvEvents.DataSource = Events;
            Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dgvEvents.DataSource = null;

            for (int i = 0; i < eventobj.Count; i++)
            {
                if (txtName.Text != eventobj[i].Name)
                {
                    throw new Exception("Name not Found!");
                }
                if (txtName.Text == eventobj[i].Name)
                {
                    eventobj[i].Distance = Convert.ToInt32(txtDistance.Text);
                    eventobj[i].IsTeamSport = txtSport.Text;
                    eventobj[i].Type = EventType.Enum.Parse(txtType.Text);
                    eventobj[i].CurrentRecord = txtCurrent.Text;
                    eventobj[i].IsMedalEvent = Convert.ToDouble(txtMedal.Text);
                }
            }
            dgvEvents.DataSource = eventobj;
            Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvEvents.DataSource = null;

            for (int i = 0; i < eventobj.Count; i++)
            {
                if (txtName.Text == eventobj[i].Name)
                {
                    eventobj.RemoveAt(i);
                }
            }
            dgvEvents.DataSource = Events;
            Refresh();
        }


    }
}
