using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB4
{
    public partial class Form1 : Form
    {
        Student[] students =
          {
            new Student(){FName="Jacob",LName="Gray",Course="AwD 100", Grade="D",Gpa="1.0" },
            new Student(){FName="Raggo",LName="Lozy",Course="AwD 100", Grade="A",Gpa="2.0" },
            new Student(){FName="Fren",LName="Seal",Course="AwD 100", Grade="F",Gpa="3.0" },
            new Student(){FName="Borb",LName="Lions",Course="AwD 100", Grade="C",Gpa="4.0" },


        };
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtLast_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchL();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            SearchF();
        }

        public void SearchF()
        {
            for (int i = 0; i < students.Length; i++)
            {
                string first = txtFirst.Text.ToLower();
                if (students[i].FName.ToLower().Contains(first))
                {
                    lblCourse.Text = students[i].Course;
                    lblGPA.Text = students[i].Gpa;
                    lblName.Text = students[i].FName + students[i].LName;
                    lblGrade.Text = students[i].Grade;
                    break;

                }
                else
                {
                    lblCourse.Text = "";
                    lblGPA.Text = "";
                    lblName.Text = "Student Not Found";
                    lblGrade.Text = "";
                }

            }
        }
        public void SearchL()
        {
            for (int i = 0; i < students.Length; i++)
            {
                string last = txtLast.Text.ToLower();
                if (students[i].LName.ToLower().Contains(last))
                {
                    lblCourse.Text = students[i].Course;
                    lblGPA.Text = students[i].Gpa;
                    lblName.Text = students[i].FName + students[i].LName;
                    lblGrade.Text = students[i].Grade;
                    break;

                }
                else
                {
                    lblCourse.Text = "";
                    lblGPA.Text = "";
                    lblName.Text = "Student Not Found";
                    lblGrade.Text = "";
                }

            }
        }

        private void FirstEnter(object sender, EventArgs e)
        {

        }

        private void FIrstDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (txtFirst.Focus()) { SearchF(); }
                    
                    break;
            }
        }

        private void txtLast_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (txtLast.Focus()) { 
                    SearchL();
            }
                    break;
            }
        }
    }
}
