using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInformationApp
{
    public partial class PersonalInformationAppUI : Form
    {
        public PersonalInformationAppUI()
        {
            InitializeComponent();
        }

        private string FirstName;
        private string LastName;
        private string FathersName;
        private string MothersName;
        private string Address;


        private void saveButton_Click(object sender, EventArgs e)
        {
            FirstName = firstNameTextBox.Text;
            LastName = lastNameTextBox.Text;
            FathersName = fathersNameTextBox.Text;
            MothersName = mothersNameTextBox.Text;
            Address = addressTextBox.Text;

            MessageBox.Show("All informations are Saved ");

            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            fathersNameTextBox.Text = string.Empty;
            mothersNameTextBox.Text = string.Empty;
            addressTextBox.Text = string.Empty;
        }

        private void showAllInformationButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Name is:" + (FirstName + LastName) + Environment.NewLine + "Your Parents is:" + (FathersName + MothersName) +Environment.NewLine+ "Your Address is:" + Address);
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Name is:"+(FirstName+LastName));
        }

        private void parentsNameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Parents is:" + (FathersName + MothersName));
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Address is:"+Address);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
