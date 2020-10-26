using LuisaKatrinaReyes.RetailApplicationSystem.windows.Models;
using LuisaKatrinaReyes.RetailApplicationSystem.windows.Helpers;
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

        public static Paged<Models.Product> Search(int pageIndex = 1, int pageSize = 1, string orderBy = "ProductName", string sortOrder = "Ascending")
        {
            Paged<Models.Product> products = new Paged<Models.Product>();
            var queryCount = db.Products.Count();
            var skip = pageSize * (pageIndex - 1);
            long pageCount = (long)Math.Ceiling((decimal)(queryCount / pageSize));

            if (orderBy.ToLower() == "ProductName" && sortOrder.ToLower() == "Ascending")
            {
                products.Items = db.Products.OrderBy(e => e.ProductName).Skip(skip).Take(pageSize).ToList();
            }
            else if (orderBy.ToLower() == "ProductName" && sortOrder.ToLower() == "Descending")
            {
                products.Items = db.Products.OrderByDescending(a => a.ProductName).Skip(skip).Take(pageSize).ToList();
            }
            else if (orderBy.ToLower() == "ProductPrice" && sortOrder.ToLower() == "Ascending")
            {
                products.Items = db.Products.OrderBy(a => a.ProductPrice).Skip(skip).Take(pageSize).ToList();
            }
            else
            {
                products.Items = db.Products.OrderByDescending(a => a.ProductPrice).Skip(skip).Take(pageSize).ToList();
            }

            products.PageCount = pageCount;
            products.QueryCount = queryCount;
            products.PageIndex = pageIndex;
            products.PageSize = pageSize;

            return products;
        }
    }
}
