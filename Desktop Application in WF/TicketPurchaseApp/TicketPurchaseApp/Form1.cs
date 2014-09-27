using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketPurchaseApp
{
    public partial class TicketPurchaseAppUI : Form
    {
        public TicketPurchaseAppUI()
        {
            InitializeComponent();
        }

        private string CustomerName;
        private double NoOfTickets=0;
        const double PER_TICKET_PRICE=10;
        private double TotalPrice=0;

        private void totalPriceButton_Click(object sender, EventArgs e)
        {
            CustomerName = customerNameTextBox.Text;
            NoOfTickets = Convert.ToDouble(noOfTicketsTextBox.Text);
            TotalPrice = PER_TICKET_PRICE*NoOfTickets;
            MessageBox.Show(CustomerName+ " , Please Pay "+TotalPrice +" Tk,to buy "+NoOfTickets+" ticket(s) ");

            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            customerNameTextBox.Text = string.Empty;
            noOfTicketsTextBox.Text = string.Empty;
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer Name: " + CustomerName+ "\nUnit Price: " + PER_TICKET_PRICE+ "\n Total Price: " + TotalPrice);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
