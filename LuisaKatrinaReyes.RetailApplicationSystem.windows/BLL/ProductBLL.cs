using LuisaKatrinaReyes.RetailApplicationSystem.windows.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuisaKatrinaReyes.RetailApplicationSystem.windows.BLL
{
    public static class ProductBLL
    {
        public static DAL.ProductDBContext db = new DAL.ProductDBContext();

        public static List<Product> Search(string orderBy = "ProductName", string sortOrder = "Ascending")
        {
            List<Product> products = new List<Product>();
            if (orderBy.ToLower() == "ProductName" && sortOrder.ToLower() == "Ascending")
            {
                products = db.Products.OrderBy(a => a.ProductName).ToList();
            }
            else if (orderBy.ToLower() == "ProductName" && sortOrder.ToLower() == "Descending")
            {
                products = db.Products.OrderByDescending(a => a.ProductName).ToList();
            }
            else if (orderBy.ToLower() == "ProductPrice" && sortOrder.ToLower() == "Ascending")
            {
                products = db.Products.OrderBy(a => a.ProductPrice).ToList();
            }
            else if (orderBy.ToLower() == "ProductPrice" && sortOrder.ToLower() == "Descending")
            {
                products = db.Products.OrderByDescending(a => a.ProductPrice).ToList();
            }
            return products;
        }
    }
}
