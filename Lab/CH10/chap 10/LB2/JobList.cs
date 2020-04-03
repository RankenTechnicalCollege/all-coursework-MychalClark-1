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
    public partial class JobList : Form
    {
         Industry[] _industries;
         public JobList( Industry[] industries)
        {
            InitializeComponent();
            _industries = industries;
        }

        private void JobList_Load(object sender, EventArgs e)
        {
            int yLocation = 10;
            foreach(Industry industryItem in _industries)
            {
                foreach (Job JobItem in industryItem.Jobs)
                {
                    LinkLabel label = new LinkLabel()
                    {
                        Text = JobItem.JobTitle,
                        Location = new Point(10, 10),
                        AutoSize = true,
                    };
                    label.Links.Add(JobItem.Link);
                    label.LinkClicked += Label_LinkClicked;
                    yLocation += 20;
                    this.Controls.Add(label);
                }
            }
        }

        private void Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }
    }
}
