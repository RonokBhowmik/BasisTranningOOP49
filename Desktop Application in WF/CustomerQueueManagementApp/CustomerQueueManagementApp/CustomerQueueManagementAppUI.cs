using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerQueueManagementApp
{
    public partial class CustomerQueueManagementAppUI : Form
    {
        public CustomerQueueManagementAppUI()
        {
            InitializeComponent();
        }

         Customer aCustomer;

         Queue<Customer> CustomerList=new Queue<Customer>();

         int countSerial =1;

        private void enqueueButton_Click(object sender, EventArgs e)
        {
            aCustomer = new Customer();

            aCustomer.CustomerName = enqueueCustomerNameTextBox.Text;

            aCustomer.CustomerComplain = enqueueCustomerComplainTextBox.Text;

            aCustomer.CustomerSerialNumber = Convert.ToInt32(countSerial.ToString());

            CustomerList.Enqueue(aCustomer);

            

            ListViewItem myItem=new ListViewItem();
            myItem.Text = aCustomer.CustomerSerialNumber.ToString();
            myItem.SubItems.Add(aCustomer.CustomerName);
            myItem.SubItems.Add(aCustomer.CustomerComplain);
            myListView.Items.Add(myItem);
           
            MessageBox.Show(aCustomer.CustomerName+"'s Serial number is:"+countSerial,"Message");
            countSerial++;

            ClearTextboxes();
        }

        private void ClearTextboxes()
        {
            enqueueCustomerNameTextBox.Text = string.Empty;
            enqueueCustomerComplainTextBox.Text = string.Empty;
        }


        private void dequeueButton_Click(object sender, EventArgs e)
        {
        
            aCustomer = CustomerList.Dequeue();
            dequeueCustomerNameTextBox.Text =aCustomer.CustomerName;
            customerSerialNoTextBox.Text=aCustomer.CustomerSerialNumber.ToString();
            dequeueComplainTextBox.Text=aCustomer.CustomerComplain;

            myListView.Items[0].Remove();
        }
    }
}
