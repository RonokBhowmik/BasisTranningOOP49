using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreetingsApp
{
    public partial class GreetingApplicationUI : Form
    {
        public GreetingApplicationUI()
        {
            InitializeComponent();
        }

       
        private void showButton_Click(object sender, EventArgs e)
        {
            String Name = nameTextBox.Text;
            MessageBox.Show(text: " Hi " + Name + " have a nice day ", caption: "Message");
           // nameTextBox.Text = string.Empty;
        }
    }
}
