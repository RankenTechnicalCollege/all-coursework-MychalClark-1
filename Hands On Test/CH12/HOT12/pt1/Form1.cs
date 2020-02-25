using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pt1
{
    public partial class PasswordCracker : Form
    {
        private List<Password> codes = new List<Password>();
        public string CrackPassword(string hash) {
            string raw = null;
            for (int i = 0; i < codes.Count; i++)
            {
                if(codes[i].Hash == hash) { raw = codes[i].Raw; break; }

            }
            
            
            return raw; }
        public PasswordCracker()
        {
            codes.Add(new Password("123456", "e10adc3949ba59abbe56e057f20f883e"));
            codes.Add(new Password("123456789", "25f9e794323b453885f5181f1b624d0b"));
            codes.Add(new Password("qwerty", "d8578edf8458ce06fbc5bb76a58c5ca4"));
            codes.Add(new Password("111111", "96e79218965eb72c92a549dd5a330112"));
            codes.Add(new Password("password", "5f4dcc3b5aa765d61d8327deb882cf99"));
            codes.Add(new Password("qwertyuiop", "6eea9b7ef19179a06954edd0f6c05ceb"));
            codes.Add(new Password("123321", "c8837b23ff8aaa8a2dde915473ce0991"));
            codes.Add(new Password("google", "c822c1b63853ed273b89687ac505f9fa"));
            codes.Add(new Password("P@ssw0rd", "161ebd7d45089b3446ee4e0d86dbcf92"));
            codes.Add(new Password("Tr0ub4dor&3", "4ece57a61323b52ccffdbef021956754"));
            

            InitializeComponent();
        }

        private void btnCrack_Click(object sender, EventArgs e)
        {
            string input = txtHash.Text;
          string raw= CrackPassword(input);
            if(raw == null) { lblResult.Text = "*FAIL*"; }
            else { lblResult.Text = $"{raw}"; }
            
        }
    }
}
