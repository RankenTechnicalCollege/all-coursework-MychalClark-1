using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTT2
{
    public partial class Form1 : Form
    {
        private List<Computer> networks = new List<Computer>();
        int[] desktop = {20,21,23,25,53,80,123,389,443 };
        int[] google = { 53 };
        int[] ranken = { 25, 80, 443 };
        


        public void ScanIpAddress(string ipAddress) {
            var computer = networks[0];
            for (int i = 0; i < networks.Count; i++)
            {
                if(networks[i].IpAddress == ipAddress) {  computer = networks[i]; break; }
            }
            
            ShowComputer(computer.Name);
            return;
        }

        public void ShowComputer(string computer)
        {
            int index = -1;
            for (int i = 0; i < networks.Count; i++)
            {
                if (computer == "") { lblComputer.Text = " Request Timed Out"; lblAddress.Text = txtAddress.Text; lblServices.Text = "None"; lblComputer.Text = "Request Timed Out"; break; }
                if (computer == networks[i].Name)
                {
                    lblComputer.Text = $"{computer}";
                    
                    lblAddress.Text = $"{networks[i].IpAddress}";
                    for (int l = 0; l < 9; l++)
                    {
                        index++;
                        if (index == networks[i].Services.Length) { break; }
                        if (networks[i].Services[l] == 20) { lblServices.Text += "\n" + $"{ networks[i].Services[l]}: FTP_DATA"; }
                        if (networks[i].Services[l] == 21) { lblServices.Text += "\n" + $"{ networks[i].Services[l]}: FTP_CONTROL"; }
                        if (networks[i].Services[l] == 23) { lblServices.Text += "\n" + $"{ networks[i].Services[l]}: TELNET"; }
                        if (networks[i].Services[l] == 25) { lblServices.Text += "\n" + $"{ networks[i].Services[l]}: SMTP"; }
                        if (networks[i].Services[l] == 53) { lblServices.Text += "\n" + $"{ networks[i].Services[l]}: DNS"; }
                        if (networks[i].Services[l] == 80) { lblServices.Text += "\n" + $"{ networks[i].Services[l]}: HTTP"; }
                        if (networks[i].Services[l] == 123) { lblServices.Text += "\n" + $"{ networks[i].Services[l]}: NTP"; }
                        if (networks[i].Services[l] == 389) { lblServices.Text += "\n" + $"{ networks[i].Services[l]}: LDAP"; }
                        if (networks[i].Services[l] == 443) { lblServices.Text += "\n" + $"{ networks[i].Services[l]}: HTTPS"; }
                        
                    }
                    
                }
                
            }
           
        }
            

        public Form1()
        {
            networks.Add(new Computer("", "", null));
            networks.Add(new Computer("My-Desktop", "127.0.0.1",desktop));
            networks.Add(new Computer("google-public-dns-a", "8.8.8.8",google));
            networks.Add(new Computer("ranken.edu", "47.44.246.80", ranken));

            InitializeComponent();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            lblServices.Text = "";
            string input = txtAddress.Text;
           ScanIpAddress(input);
            
            
            
        }
    }
}
