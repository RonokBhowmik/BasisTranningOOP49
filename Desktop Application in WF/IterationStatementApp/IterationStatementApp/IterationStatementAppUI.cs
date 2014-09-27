using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IterationStatementApp
{
    public partial class IterationStatementAppUI : Form
    {
        public IterationStatementAppUI()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
           mylistBox.Text = string.Empty;
           int ItemNumber = Convert.ToInt32(itemNumberTextBox.Text);
           for(int i=1;i<=ItemNumber;i++)
            {
                mylistBox.Items.Add(i);
            }
            itemNumberTextBox.Text = string.Empty;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
             MessageBox.Show(text: "The Value of the selected Number is:"+mylistBox.SelectedItem.ToString()+
                 Environment.NewLine+"The Index of the selected Number is:"+mylistBox.SelectedIndex.ToString());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
