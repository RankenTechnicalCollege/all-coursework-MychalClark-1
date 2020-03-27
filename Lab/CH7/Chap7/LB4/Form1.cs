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
        public List<Account> people = new List<Account>();
        public Form1()
        {
            people.Add(new Account("Tommy", "TomTom", "Thomas", false));
            people.Add(new Account("Sammy", "SamSam", "Samuel", true));
            people.Add(new Account("Chrissy", "ChrisChris", "Christopher", false));
            people.Add(new Account("Addy", "AddAdd", "Adamuel", false));
            people.Add(new Account("Drey", "DreDre", "Drake", true));
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try { if (txtName.Text == "" || txtPass.Text == "") { throw new NoUsernamePasswordException();  }

               var person = Login(txtName.Text,txtPass.Text);
            
            }




            catch(NoUsernamePasswordException ex) { lblResult.Text = ex.Message; }

        }

            public Account Login(string username, string password)
            {
            var j = people[0];
            for (int i = 0; i <= people.Count; i++)
            {
                try { if (i == people.Count) { throw new IncorrectPasswordException();  } }
                catch (IncorrectPasswordException ex) { lblResult.Text = ex.Message; break; }

                if (people[i].Username == username&& people[i].Password == password ) {
                    j = people[i];
                    try { if (people[i].Disabled) { throw new AccountDisabledException(); }

                        else { lblResult.Text = $"Welcome{people[i].FirstName} "; }
                    }
                    catch(AccountDisabledException ex) { lblResult.Text = ex.Message;
                   
                    }

                   


                    ; break;
                }
                
            }

            return j;




        }
        }

    }

