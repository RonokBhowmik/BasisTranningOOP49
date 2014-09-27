using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameStoringApp
{
    public partial class NameStoringAppUI : Form
    {
        public NameStoringAppUI()
        {
            InitializeComponent();
        }

        private List<string> NameList = new List<string>(); 

        //const int MAX_STUDENT=5;
        private int SetCount = 0;
        int Namecount =1;
        private void NameStoringAppUI_Load(object sender, EventArgs e)
        {
            this.addNameButton.Enabled = false;
        }
    
        private void setButton_Click(object sender, EventArgs e)
        {
            if (setCountTextBox.Text ==null)
            {
                MessageBox.Show("Fill the Count TextBox First!!!");
           
            }
            else
            {
                 SetCount = int.Parse(setCountTextBox.Text);

            }

            this.addNameButton.Enabled = true;
        }
        private void addNameButton_Click(object sender, EventArgs e)
        {
            string aName = nameTextBox.Text;

            nameTextBox.Text = string.Empty;

            if ((Namecount) <= SetCount)
            {
                NameList.Add(aName);
                Namecount++;
                countTextBox.Text = NameList.Count().ToString();
                MessageBox.Show("Name Added Successfully");

            }
            else
            {
                MessageBox.Show("Out Of Range!!!!", "Message");
                this.addNameButton.Enabled = false;
            }
           
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
           nameTextBox.Text = string.Empty;
           countTextBox.Text = string.Empty;
           myListBox.Items.Clear();
           this.addNameButton.Enabled =true;
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
           
            myListBox.Items.Clear();

            foreach (string aName in NameList)
            {
                myListBox.Items.Add(aName);
            }
           
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

       
    }
}
