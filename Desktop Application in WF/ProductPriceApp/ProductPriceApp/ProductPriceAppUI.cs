using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductPriceApp
{
    public partial class ProductPriceAppUI : Form
    {
        public ProductPriceAppUI()
        {
            InitializeComponent();
        }

        String aProductName;

        private int NoOfProducts=0;

        private int Total=0;

        List<string> productslList=new List<string>();
 

        private void addButton_Click(object sender, EventArgs e)
        {
            aProductName = productsComboBox.Text;
            myListView.Items.Add(aProductName);

            //myDataGridView.AutoGenerateColumns = false;
            //myDataGridView.DataSource = ProductsName;
            //myDataGridView.Columns[0].DataPropertyName = "Product Name";
            //myDataGridView.Columns[1].DataPropertyName = "Unit Price";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        
    }
}
