using LuisaKatrinaReyes.RetailApplicationSystem.windows.DAL;
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

            RetailuserDBContext context = new RetailuserDBContext();

            var Retailuser = context.Retailusers.FirstOrDefault();

            if (Retailuser != null)
            {
                MessageBox.Show(Retailuser.FirstName);
            }

        }
    }
}
