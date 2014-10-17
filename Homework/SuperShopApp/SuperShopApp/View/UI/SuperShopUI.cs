using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperShopApp.DLL.DAO;

namespace SuperShopApp
{
    public partial class SuperShopUI : Form
    {
        public SuperShopUI()
        {
            InitializeComponent();
        }

          private Shop aShop;

          private Product aProduct=new Product();

        private void saveButton_Click(object sender, EventArgs e)
        {

            aShop = new Shop(shopNameTextBox.Text,shopAddressTextBox.Text);

            string connectionString = @"server=RONOK-PC\SQLEXPRESS;database=ShopProductDB;integrated security=true";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string queryString = string.Format("INSERT INTO ShopTable VALUES('{0}','{1}')", aShop.ShopName, aShop.ShopAddress);
            SqlCommand command = new SqlCommand(queryString, connection);

            int effecttedRows = command.ExecuteNonQuery();
            connection.Close();
            if (effecttedRows > 0)
            {
                MessageBox.Show(@"Shop Created");
            }
            else
            {
                MessageBox.Show(@"something wrong");
            }
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            aProduct.ProductId = Convert.ToInt32(productIdTextBox.Text);
            aProduct.ProductQuantity = Convert.ToInt32(productQuantityTextBox.Text);
            string msg= aShop.Add(aProduct);
            MessageBox.Show(msg);
          
            string connectionString = @"server=RONOK-PC\SQLEXPRESS;database=ShopProductDB;integrated security=true";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string queryString = string.Format("INSERT INTO ProductTable VALUES({0},{1})", aProduct.ProductId, aProduct.ProductQuantity);
            SqlCommand command = new SqlCommand(queryString, connection);

            int effecttedRows = command.ExecuteNonQuery();
            connection.Close();

        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            //string connectionString = @"server=RONOK-PC\SQLEXPRESS;database=ShopProductDB;integrated security=true";
            //SqlConnection connection = new SqlConnection(connectionString);
            //connection.Open();
            //string queryString = string.Format("SELECT* FROM dbo.ProductTable INNER JOIN dbo.ShopTable ON dbo.ProductTable.ShopId=dbo.ShopTable.ShopId");
            //SqlCommand command = new SqlCommand(queryString, connection);
            //int effecttedRows = command.ExecuteNonQuery();
            //connection.Close();
        }
    }
}
