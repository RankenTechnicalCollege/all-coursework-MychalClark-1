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
        List<Order> package = new List<Order>();
        public Form1()
        {
            package.Add(new Order(0, 0, 0) );
           
            InitializeComponent();
        }

        private void btnVal_Click(object sender, EventArgs e)
        { short itemNum;
            byte quan, days;
            try { if (!short.TryParse(txtNum.Text, out itemNum)) { throw new InvalidItemNumberException(); }
                 if (!byte.TryParse(txtQuan.Text, out quan)) { throw new InvalidQuantityException();
                }
                 if (!byte.TryParse(txtDays.Text, out days))
                {
                    throw new InvalidDeliveryDaysException(); }

                if(itemNum <100 || itemNum > 999) { throw new InvalidItemNumberException(); }
                else if(quan < 1 || quan > 12) { throw new InvalidQuantityException(); }
                else if (days < 1 || days > 30) { throw new InvalidDeliveryDaysException(); }

                package[0].ItemNumber = itemNum;
                package[0].Quantity = quan;
                package[0].EstimatedDeliveryDays = days;
                lblResult.Text ="Order is valid";


            }





            catch (InvalidItemNumberException ex) { lblResult.Text = ex.Message; }
            catch (InvalidQuantityException ex) { lblResult.Text = ex.Message; }
            catch (InvalidDeliveryDaysException ex) { lblResult.Text = ex.Message; }

        }
    }
}
