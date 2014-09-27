using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculator
{
    public partial class SalaryCalculatorAppUI : Form
    {
        public SalaryCalculatorAppUI()
        {
            InitializeComponent();
        }

        Salary aSalary = new Salary();

        private void showMeSalaryButton_Click(object sender, EventArgs e)
        {
            aSalary.employeeName = employeeNameTextBox.Text;
            aSalary.basicAmount = Convert.ToDouble(basicAmountTextBox.Text);
            aSalary.houseRentPercent = Convert.ToDouble(houseRentTextBox.Text);
            aSalary.medicalAllowancePercent = Convert.ToDouble(medicalAllowanceTextBox.Text);
            MessageBox.Show(aSalary.employeeName + @",your total salary is:" + aSalary.GetTotal().ToString(), @"Message");
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            employeeNameTextBox.Text = string.Empty;
            basicAmountTextBox.Text = string.Empty;
            houseRentTextBox.Text = string.Empty;
            medicalAllowanceTextBox.Text = string.Empty;

        }
    }
}
