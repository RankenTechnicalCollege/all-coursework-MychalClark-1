using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB6
{
    public partial class Form1 : Form
    {
        private List<Room> Rooms = new List<Room>();
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAdd_Click(object sender, EventArgs e)
        {
            string namers = txtName.Text;
            int width = Convert.ToInt32(txtWidth.Text);
            int length = Convert.ToInt32(txtLength.Text);

            Rooms.Add(new Room(namers, width, length));

            lblRooms.Text = $"{Rooms.Count}/20";
            lblPlaces.Text = "";
            int theseboxes = 0;
            for (int i = 0; i < Rooms.Count; i++)
            {
               theseboxes += Rooms[i].Boxes;
                lblPlaces.Text += Rooms[i].Display();


            }
            lblNeeded.Text = $"{theseboxes}";


            txtLength.Text = "";
            txtName.Text = "";
            txtWidth.Text = "";
            txtName.Focus();
        }
    }
}
