using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxMinTestingApp
{
    public partial class MaxMinTestingAppUI : Form
    {
        public MaxMinTestingAppUI()
        {
            InitializeComponent();
        }

        private int NumberOne;
        private int NumberTwo;
        private int NumberThree;
        private int NumberFour;
        private int NumberFive;
        private int MaximumNumber;
        private int MinimumNumber;

        private void findMaxMinButton_Click(object sender, EventArgs e)
        {
    
            NumberOne = int.Parse(numberOneTextBox.Text);
            NumberTwo = int.Parse(numberTwoTextBox.Text);
            NumberThree =int.Parse(numberThreeTextBox.Text);
            NumberFour = int.Parse(numberFourTextBox.Text);
            NumberFive = int.Parse(numberFiveTextBox.Text);

           
            MaximumNumber = Math.Max(Math.Max(Math.Max(Math.Max(NumberOne, NumberTwo), NumberThree), NumberFour),NumberFive);
            MinimumNumber = Math.Min(Math.Max(Math.Min(Math.Min(NumberOne, NumberTwo), NumberThree), NumberFour), NumberFive);
            
            label8.Text = MaximumNumber.ToString();
            label9.Text = MinimumNumber.ToString();

        }
    }
}
