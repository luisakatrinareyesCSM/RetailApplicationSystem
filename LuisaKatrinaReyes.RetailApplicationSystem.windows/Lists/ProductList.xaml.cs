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
    /// Interaction logic for ProductList.xaml
    /// </summary>
    public partial class ProductList : Window
    {
        private string orderBy = "ProductName";
        private string sortOrder = "Ascending";
        public ProductList()
        {
            InitializeComponent();
        }

        private void cboSortOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            orderBy = cboOrderBy.SelectedValue.ToString();
            showData();
        }

        private void showData()
        {
            dgProducts.ItemsSource = ProductBLL.Search(orderBy, sortOrder);

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
