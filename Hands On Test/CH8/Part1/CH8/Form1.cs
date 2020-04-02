using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string[] firstName = { "Markel", "Luiza", "Bryony","Giraldo","Lowri" };
            string[] lastName = {  "Diggory", "Gunnar", "Hester","Addy","Hari"  };
            string[] phone = { "555-8390", "555-4618", "555-4440","555-1687","555-7763" };
            lblFound.Text = "";

            txtName.Text.ToLower();
          
            string enter = txtName.Text;
            
           string enterUp = enter.Substring(0, 1).ToUpper() + enter.Substring(1);

            



            for (int i = 0; i < firstName.Length; i++)
            {

                if (firstName[i].Contains(enterUp) || lastName[i].Contains(enterUp))
                { lblFirst.Text = $"{firstName[i]}"; lblLast.Text = $"{lastName[i]}"; lblPhone.Text = $"{phone[i]}"; break; }

                if (i == 4){ lblFirst.Text = $"Error"; lblLast.Text = $"Error"; lblPhone.Text = $"Error"; lblFound.Text = $"User Not Found"; }
                
            }
             
        }
    }
}
