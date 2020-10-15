using LuisaKatrinaReyes.RetailApplicationSystem.windows.BLL;
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
using System.Windows.Shapes;

namespace LuisaKatrinaReyes.RetailApplicationSystem.windows.Lists
{
    /// <summary>
    /// Interaction logic for CustomerList.xaml
    /// </summary>
    public partial class CustomerList : Window
    {
        private string customerorderBy = "CustomerName";
        private string sortOrder = "Ascending";
        public CustomerList()
        {
            InitializeComponent();
        }

        private void cboSortOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            customerorderBy = cboOrderBy.SelectedValue.ToString();
            showData();
        }

        private void showData()
        {
            dgCustomer.ItemsSource = CustomerBLL.Search(customerorderBy, sortOrder);

        }

        private void cboOrderBy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboSortOrder.SelectedValue.ToString().ToLower() == "Ascending")
            {
                sortOrder = "Ascending";
            }
            else
            {
                sortOrder = "Descending";
            }
        }
    }
}
