using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class BankAppUI : Form
    {
        public BankAppUI()
        {
            InitializeComponent();
        }

        private void calculateInterestButton_Click(object sender, EventArgs e)
        {
            string BankName = bankNameComboBox.Text;
            double Time = Convert.ToDouble(timeTextBox.Text);
            double Balance = Convert.ToDouble(balanceTextBox.Text);

            double Interest = 0;

            if (BankName == "BRAC")
            {
                Interest = (Balance*Time*6)/100;
                interestTextBox.Text = Interest.ToString();

            }
            else if (BankName == "DBBL")
            {
                Interest = (Balance * Time * 7) / 100;
                interestTextBox.Text = Interest.ToString();
            }
            else if (BankName == "HSBC")
            {
                Interest = (Balance * Time * 8) / 100;
                interestTextBox.Text = Interest.ToString();
            }
            else
            {
                MessageBox.Show("I donot know");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            bankNameComboBox.Text = string.Empty;
            timeTextBox.Text = string.Empty;
            balanceTextBox.Text = string.Empty;
            interestTextBox.Text = string.Empty;
        }
    }
}
