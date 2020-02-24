using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHap12
{
    public partial class Form1 : Form
    {
        private List<FlashCard> mycards = new List<FlashCard>();
        public Form1()
        { mycards.Add(new FlashCard("SQL", "Structured query Language"));
            mycards.Add(new FlashCard("HTML", "HyperText Markup Language"));
            mycards.Add(new FlashCard("CSS", "Cascading StyleSheet"));
            mycards.Add(new FlashCard("JS", "JavaScript"));
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string inputTerm = txtTerm.Text.ToLower();
            bool found = false;
            btnAdd.Visible = false;
            txtDef.Visible = false;

            for (int i = 0; i < mycards.Count; i++)
            {
                if (mycards[i].GetTerm().ToLower() == inputTerm) { lblDef.Text = mycards[i].GetDefinition();
                    found = true;
                }

            }
            if (found == false) { lblDef.Text = "I dont know that term yet. what does it mean";
                btnAdd.Visible = true;
                txtDef.Visible = true;
                }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = true;
            txtDef.Visible = true;
            mycards.Add(new FlashCard(txtTerm.Text, txtDef.Text));
            MessageBox.Show("New FlashCard Added");
            txtDef.Text = "";
            lblDef.Text = "";
            btnAdd.Visible = false;
            txtDef.Visible = false;

        }
    }
}
