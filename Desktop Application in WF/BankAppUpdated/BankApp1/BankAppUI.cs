using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp1
{
    public partial class BankAppUI : Form
    {
        public BankAppUI()
        {
            InitializeComponent();
        }

        CalculateInterest aInterest=new CalculateInterest();

        private void calculateInterestButton_Click(object sender, EventArgs e)
        {
            aInterest.BankName = bankNameTextBox.Text;
            aInterest.Time = Convert.ToDouble(timeTextBox.Text);
            aInterest.Balance = Convert.ToDouble(balanceTextBox.Text);

            MessageBox.Show(aInterest.GetInterest() "Message",);

        }
    }
}
