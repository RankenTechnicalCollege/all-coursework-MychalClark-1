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
         Industry[] selectedIndustries;

        Job[] itJobs =
        {
            new Job("Junior Developer",new LinkLabel.Link(){LinkData ="https://www.google.com/search?q=junior+developer&rlz=1C1CHBF_enUS864US864&oq=junior+developer&aqs=chrome..69i57j0l7.5009j0j7&sourceid=chrome&ie=UTF-8&ibp=htl;jobs&sa=X&ved=2ahUKEwiFk_Lpu8zoAhWTKM0KHaVWD9YQp4wCMAB6BAgLEAE#htidocid=Gs49A5kloxQnB4oIAAAAAA%3D%3D&sxsrf=ALeKk025egmOPVQrBZhOUkQzKVqFtcKJ-Q:1585924143883" }),
            new Job("Junior Web Developer",new LinkLabel.Link(){LinkData ="https://flatironschool.com/welcome-to-flatiron-school/software-engineering/?utm_source=Google&utm_medium=ppc&utm_campaign=1776972610&utm_content=77604743438&utm_term=software%20developer&uqaid=428700102469&CjwKCAjwvZv0BRA8EiwAD9T2VXmOCyYsQpgmXIgp_AXv7_UGk0u3vpBpSIBDn4aG-K85WeoQLJSTMBoC8jQQAvD_BwE&gclid=CjwKCAjwvZv0BRA8EiwAD9T2VXmOCyYsQpgmXIgp_AXv7_UGk0u3vpBpSIBDn4aG-K85WeoQLJSTMBoC8jQQAvD_BwE" }),
            new Job("Software Engineer",new LinkLabel.Link(){LinkData ="https://www.veteransunited.com/careers/stl/" }),

        };

        Job[] automotiveJobs =
        {
             new Job("Technician",new LinkLabel.Link(){LinkData ="https://www.google.com/search?q=junior+developer&rlz=1C1CHBF_enUS864US864&oq=junior+developer&aqs=chrome..69i57j0l7.5009j0j7&sourceid=chrome&ie=UTF-8&ibp=htl;jobs&sa=X&ved=2ahUKEwiFk_Lpu8zoAhWTKM0KHaVWD9YQp4wCMAB6BAgLEAE#htidocid=Gs49A5kloxQnB4oIAAAAAA%3D%3D&sxsrf=ALeKk025egmOPVQrBZhOUkQzKVqFtcKJ-Q:1585924143883" }),
            new Job("Mechanic",new LinkLabel.Link(){LinkData ="https://flatironschool.com/welcome-to-flatiron-school/software-engineering/?utm_source=Google&utm_medium=ppc&utm_campaign=1776972610&utm_content=77604743438&utm_term=software%20developer&uqaid=428700102469&CjwKCAjwvZv0BRA8EiwAD9T2VXmOCyYsQpgmXIgp_AXv7_UGk0u3vpBpSIBDn4aG-K85WeoQLJSTMBoC8jQQAvD_BwE&gclid=CjwKCAjwvZv0BRA8EiwAD9T2VXmOCyYsQpgmXIgp_AXv7_UGk0u3vpBpSIBDn4aG-K85WeoQLJSTMBoC8jQQAvD_BwE" }),
            new Job("Supervisor",new LinkLabel.Link(){LinkData ="https://www.veteransunited.com/careers/stl/" }),

        };

        Job[] hvacJobs =
        {
            new Job("HVAC Installer",new LinkLabel.Link(){LinkData ="https://www.veteransunited.com/careers/stl/" }),

        };
        public Form1()
        {
            InitializeComponent();

            lstIndustries.Items.AddRange(new Industry[] 
            {
                new Industry("information Technology", itJobs),
                new Industry("Automotive", automotiveJobs),
                new Industry("Hvac", hvacJobs)
            }
                );
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndustries = new Industry[lstIndustries.SelectedItems.Count];

            for (int i = 0; i < lstIndustries.SelectedItems.Count; i++)
            {
                selectedIndustries[i] = (Industry)lstIndustries.SelectedItems[i];

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            JobList jobList = new JobList(selectedIndustries);
            jobList.ShowDialog();
        }
    }
}
