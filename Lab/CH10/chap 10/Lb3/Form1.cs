using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lb3
{
    public partial class t : Form
    {
        public t()
        {
            InitializeComponent();
        }

        private void AnyTextbox_Click(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.Yellow;
        }

        private void AnyTextbox_Focus(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.LightBlue;
        }

        private void AnyTextbox_Leave(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.BackColor = Color.LightGray;
        }

        private void AnyTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    txt1.Focus();
                    break;
                case Keys.Right:
                    txt3.Focus();
                    break;
                case Keys.Down:
                    txt5.Focus();
                    break;
                case Keys.Left:
                    txt7.Focus();
                    break;

            }
        }
    }
}
