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
    /// Interaction logic for RetailUserList.xaml
    /// </summary>
    public partial class RetailUserList : Window
    {
        private string retailuserorderBy = "LastName";
        private string sortOrder = "Ascending";
        public RetailUserList()
        {
            InitializeComponent();
        }

        private void cboSortOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            retailuserorderBy = cboOrderBy.SelectedValue.ToString();
            showData();
        }

        private void showData()
        {
            dgRetailUser.ItemsSource = RetailUserBLL.Search(retailuserorderBy, sortOrder);

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
