using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketPurchaseApp1
{
    public partial class TicketPurchaseAppUI : Form
    {
        public TicketPurchaseAppUI()
        {
            InitializeComponent();
        }

    

        Ticket aTicket=new Ticket();

        private void totalPriceButton_Click(object sender, EventArgs e)
        {
            aTicket.CustomerName = customerNameTextBox.Text;
            aTicket.NoOfTickets = Convert.ToDouble(noOfTicletsTextBox.Text);

        
            MessageBox.Show(aTicket.CustomerName+", Please Pay "+aTicket.GetTotalPrice()+" to buy "+aTicket.NoOfTickets+" ticket(s) ","Message");

            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            customerNameTextBox.Text = string.Empty;
            noOfTicletsTextBox.Text = string.Empty;
        }


        private void detailsButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
