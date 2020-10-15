using LuisaKatrinaReyes.RetailApplicationSystem.windows.DAL;
using LuisaKatrinaReyes.RetailApplicationSystem.windows.Models;
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

namespace LuisaKatrinaReyes.RetailApplicationSystem.windows
{
 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //CustomerDBContext context = new CustomerDBContext();

            //var Customer = context.Customers.FirstOrDefault();

            //if (Customer != null)
            //{
            //    MessageBox.Show(Customer.CustomerName);
            //}

        }

        private void btnRetailUsers_Click(object sender, RoutedEventArgs e)
        {
            Lists.RetailUserList listWindow = new Lists.RetailUserList();
            listWindow.Show();
        }

        private void btnCustomers_Click(object sender, RoutedEventArgs e)
        {
            Lists.CustomerList listWindow = new Lists.CustomerList();
            listWindow.Show();
        }

        private void btnProducts_Click(object sender, RoutedEventArgs e)
        {
            Lists.ProductList listWindow = new Lists.ProductList();
            listWindow.Show();
        }
    }
}
