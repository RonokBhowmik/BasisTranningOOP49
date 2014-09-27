using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircleAreaCalculationApp
{
    public partial class AreaCalculatorAppUI : Form
    {
        public AreaCalculatorAppUI()
        {
            InitializeComponent();
        }
        const double PI= 3.1416;

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double Radius = Convert.ToDouble(radiusTextBox.Text);
            double Area = PI*Radius*Radius;
            areaTextBox.Text= Area.ToString();
        }
    }
}
