using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryApp
{
    public partial class EmployeeSalaryBonusCalculatorAppUI : Form
    {
        public EmployeeSalaryBonusCalculatorAppUI()
        {
            InitializeComponent();
        }

         private int Bonus=0;
         private int Salary=0;
         private void calculateBonusButton_Click(object sender, EventArgs e)
         {
            if (Salary>10000)
            {
                Salary = Convert.ToInt32(employeeSalaryTextBox.Text);
                Bonus = 5;
                bonusTextBox.Text = Bonus.ToString();
                grossSalaryTextBox.Text = (Salary + (Salary * Bonus) / 100).ToString();
            }
            else if (Salary >= 8000 && Salary <= 10000)
            {
                Salary = Convert.ToInt32(employeeSalaryTextBox.Text);
                Bonus = 6;
                bonusTextBox.Text = Bonus.ToString();
                grossSalaryTextBox.Text = (Salary + (Salary * Bonus) / 100).ToString();
            }
            else
            {
                Salary = Convert.ToInt32(employeeSalaryTextBox.Text);
                Bonus = 7;
                bonusTextBox.Text = Bonus.ToString();
                grossSalaryTextBox.Text = (Salary + (Salary * Bonus) / 100).ToString();
            }
           employeeSalaryTextBox.Text = string.Empty;            
        }

         private void resetButton_Click(object sender, EventArgs e)
         {
             employeeSalaryTextBox.Text = string.Empty;
             bonusTextBox.Text = string.Empty;
             grossSalaryTextBox.Text = string.Empty;
         }
    }
}
