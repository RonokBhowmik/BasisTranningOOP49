using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalktimeCalculatorApp
{
    public partial class TalktimeCalculatorAppUI : Form
    {
        public TalktimeCalculatorAppUI()
        {
            InitializeComponent();
        }
        string OperatorName;
        string PaymentType;
        double Balance;
        double TalkTime;
        private void calculateTalktimeButton_Click(object sender, EventArgs e)
        {
          OperatorName=operatorNameComboBox.Text;
          PaymentType=paymentTypeComboBox.Text;
          Balance =double.Parse(balanceTextBox.Text);
          if (OperatorName == "GrammenPhone" && PaymentType == "Prepaid")
            {
                TalkTime = Balance / 1.18;
            }
          else if (OperatorName == "Banglalink" && PaymentType  == "Prepaid")
          {
              TalkTime = Balance  / 1.05;
          }
          else if (OperatorName == "Airtel" && PaymentType  == "Prepaid")
          {
              TalkTime =Balance  / 1.10;
          }
          else if (OperatorName == "Robi" && PaymentType  == "Prepaid")
          {
              TalkTime = Balance  / 1.7;
          }
          else
          {
              label5.Text = "Check Your Operator";
          }
          label5.Text = TalkTime.ToString();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            balanceTextBox.Text = string.Empty;
            operatorNameComboBox.Text = string.Empty;
            paymentTypeComboBox.Text = string.Empty;
            label5.Text = string.Empty;
        }
        }
    }
