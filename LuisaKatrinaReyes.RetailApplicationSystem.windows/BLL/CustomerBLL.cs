using LuisaKatrinaReyes.RetailApplicationSystem.windows.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuisaKatrinaReyes.RetailApplicationSystem.windows.BLL
{
    public static class CustomerBLL
    {
        public static DAL.CustomerDBContext db = new DAL.CustomerDBContext();

        public static List<Customer> Search(string customerorderBy = "CustomerName", string sortOrder = "Ascending")
        {
            List<Customer> customers = new List<Customer>();
            if (customerorderBy.ToLower() == "CustomerName" && sortOrder.ToLower() == "Ascending")
            {
                customers = db.Customers.OrderBy (a => a.CustomerName).ToList();
            }
            else if (customerorderBy.ToLower() == "ProductName" && sortOrder.ToLower() == "Descending")
            {
                customers = db.Customers.OrderByDescending(a => a.CustomerName).ToList();
            }
            return customers;
        }
    }
}
