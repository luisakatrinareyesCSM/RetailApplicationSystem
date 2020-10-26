using LuisaKatrinaReyes.RetailApplicationSystem.windows.Models;
using LuisaKatrinaReyes.RetailApplicationSystem.windows.Helpers;
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

        public static Paged<Models.Customer> Search(int pageIndex = 1, int pageSize = 1, string customerorderBy = "CustomerName", string sortOrder = "Ascending")
        {
            Paged<Models.Customer> customers = new Paged<Models.Customer>();
            var queryCount = db.Customers.Count();
            var skip = pageSize * (pageIndex - 1);
            long pageCount = (long)Math.Ceiling((decimal)(queryCount / pageSize));

            if (customerorderBy.ToLower() == "CustomerName" && sortOrder.ToLower() == "Ascending")
            {
                customers.Items = db.Customers.OrderBy(a => a.CustomerName).Skip(skip).Take(pageSize).ToList();
            }
            else if (customerorderBy.ToLower() == "ProductName" && sortOrder.ToLower() == "Descending")
            {
                customers.Items = db.Customers.OrderByDescending(a => a.CustomerName).Skip(skip).Take(pageSize).ToList();
            }

            customers.PageCount = pageCount;
            customers.QueryCount = queryCount;
            customers.PageIndex = pageIndex;
            customers.PageSize = pageSize;

            return customers;
        }
    }
}
