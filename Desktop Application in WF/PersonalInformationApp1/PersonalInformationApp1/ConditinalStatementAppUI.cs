using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInformationApp1
{
    public partial class ConditinalStatementAppUI : Form
    {
        public ConditinalStatementAppUI()
        {
            InitializeComponent();
        }

        private void planetNumberButton_Click(object sender, EventArgs e)
        {
           string PlanetName = planetNameComboBox.Text;
            if (PlanetName == "Planet")
            {
                MessageBox.Show("This is the 1st Planet");
            }
            else if (PlanetName == "Earth")
            {
                MessageBox.Show("This is the 4th Planet");
            }
            else  if (PlanetName == "Mars")
            {
                MessageBox.Show("This is the 3rd Planet");
            }
            else if (PlanetName == "Jupitar")
            {
                MessageBox.Show("This is the Biggest Planet");
            }
            else
            {
                MessageBox.Show("I donot Know");
            }
        }

        
    }
}
