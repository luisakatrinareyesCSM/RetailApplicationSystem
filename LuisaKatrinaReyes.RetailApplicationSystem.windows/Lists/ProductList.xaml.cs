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
        private int pageSize = 1;
        private int pageIndex = 1;
        private long pageCount = 1;
        public ProductList()
        {
            InitializeComponent();
            cboOrderBy.ItemsSource = new List<string>() { "ProductName", "ProductPrice" };
            cboSortOrder.ItemsSource = new List<string>() { "Ascending", "Descending" };

            showData();
        }

        private void cboOrderBy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            orderBy = cboOrderBy.SelectedValue.ToString();
            showData();
        }

        private void showData()
        {
            var products = ProductBLL.Search(pageIndex, pageSize, orderBy, sortOrder);

            dgProducts.ItemsSource = products.Items;
            pageCount = products.PageCount;
        }

        private void cboSortOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
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

        private void btnFirst_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = 1;
            showData();
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = pageIndex - 1;
            if (pageIndex < 1)
            {
                pageIndex = 1;
            };
            showData();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = pageIndex + 1;
            if (pageIndex > pageCount)
            {
                pageIndex = (int)pageCount;
            };
            showData();
        }

        private void btnLast_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = (int)pageCount;
            showData();
        }

        private void txtPageSize_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtPageSize.Text.Length > 0)
            {
                int.TryParse(txtPageSize.Text, out pageSize);
            }

            showData();
        }
    }
}
