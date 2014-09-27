using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class CalculatorAppUI : Form
    {
        public CalculatorAppUI()
        {
            InitializeComponent();
        }

        Calculator aCalculator=new Calculator();

        private void AddButton_Click(object sender, EventArgs e)
        {
           resultTextBox.Text=aCalculator.Add(firstNumberTextBox.Text,secondNumberTextBox.Text);
           ClearTextBoxes();
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = aCalculator.Subtract(Convert.ToDouble(firstNumberTextBox.Text), Convert.ToDouble(secondNumberTextBox.Text)).ToString(); 
            ClearTextBoxes();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = aCalculator.Multiply(Convert.ToDouble(firstNumberTextBox.Text), Convert.ToDouble(secondNumberTextBox.Text)).ToString(); 
            ClearTextBoxes();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = aCalculator.Divide(Convert.ToDouble(firstNumberTextBox.Text), Convert.ToDouble(secondNumberTextBox.Text)).ToString(); 
            ClearTextBoxes();
        }
        private void ClearTextBoxes()
        {
            firstNumberTextBox.Text = string.Empty;
            secondNumberTextBox.Text = string.Empty;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
