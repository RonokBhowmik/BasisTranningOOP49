using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VariousMessages
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Message1Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Message Format One");
        }

        private void Message2Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is Message Format Two", "Message");
        }

        private void Message3Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is Message Format Three","Message",MessageBoxButton.OKCancel);
        }

        private void Message4Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is Message Format Four","Message",MessageBoxButton.YesNoCancel,MessageBoxImage.Asterisk);
        }

        private void Message5Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is Message Box Format Five","Message",MessageBoxButton.YesNoCancel,MessageBoxImage.Exclamation,MessageBoxResult.OK);
        }

       
    }
}
