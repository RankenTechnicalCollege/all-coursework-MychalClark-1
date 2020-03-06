using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB2
{
    public partial class Form1 : Form
    {
        List<Conference> conferences = new List<Conference>();
        int addMe = 0;
        public Form1()
        {


            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";

            string groupName = txtName.Text;
            DateTime date = Convert.ToDateTime(txtDate.Text);
            date.ToLongDateString();
            int attendeesNum = Convert.ToInt32(txtAttendees.Text);
            Room r1 = (Room)Convert.ToInt32(txtRooms.Text);
            


            conferences.Add(new Conference() { GroupName = groupName, StartingDate = date, Attendees = attendeesNum, Room = r1 });
            lblConfrences.Text = $"{conferences.Count}/20";
            addMe += attendeesNum;

            lblTotal.Text = $"{addMe}";

            txtAttendees.Text = "";
            txtDate.Text = "";
            txtRooms.Text = "";
            txtName.Text = "";
            txtName.Focus();
            if (conferences.Count == 20) { button1.Enabled = false; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";

            DateTime begin = Convert.ToDateTime(txtBegin.Text);
            DateTime end = Convert.ToDateTime(txtEnd.Text);

            for (int i = 0; i < conferences.Count; i++)
            {
                if (begin <= conferences[i].StartingDate && conferences[i].StartingDate <= end) { lblResult.Text += conferences[i].Display(); }
            }


        }
    }
}
