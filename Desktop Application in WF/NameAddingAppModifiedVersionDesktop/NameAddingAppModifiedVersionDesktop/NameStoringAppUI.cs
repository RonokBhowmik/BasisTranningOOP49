using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameAddingAppModifiedVersionDesktop
{
    public partial class NameStoringAppUI : Form
    {
        public NameStoringAppUI()
        {
            InitializeComponent();
        }

        private int SetCount=0;

        private string aName;

        private List<string> nameList=new List<string>();

        private int NameCount=0;


        private void NameStoringAppUI_Load(object sender, EventArgs e)
        {
            addButton.Enabled = false;
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            SetCount = Convert.ToInt32(setCountTextBox.Text);
            addButton.Enabled = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            aName = addNameTextBox.Text;
            if (NameCount <= SetCount)
            {
                nameList.Add(aName);
                NameCount++;
                label3.Text = nameList.Count().ToString();
                MessageBox.Show(text: "Name Saved Successfully");
                addNameTextBox.Text = string.Empty;
                
            }

            else
            {
                addButton.Enabled = false;
                MessageBox.Show(text: "Out Of Range!!!!");
                
            }

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            setCountTextBox.Text = string.Empty;
            addNameTextBox.Text = string.Empty;
            label3.Text = string.Empty;
            myListBox.Items.Clear();
            addButton.Enabled = true;
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            myListBox.Items.Clear();
            foreach (string aName in nameList)
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
