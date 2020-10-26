using LuisaKatrinaReyes.RetailApplicationSystem.windows.Models;
using LuisaKatrinaReyes.RetailApplicationSystem.windows.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuisaKatrinaReyes.RetailApplicationSystem.windows.BLL
{
    public static class RetailUserBLL
    {
        public static DAL.RetailuserDBContext db = new DAL.RetailuserDBContext();

        public static Paged<Models.Retailuser> Search(int pageIndex = 1, int pageSize = 1, string orderBy = "LastName", string sortOrder = "Ascending")
        {

            Paged<Models.Retailuser> retailusers = new Paged<Models.Retailuser>();
            var queryCount = db.Retailusers.Count();
            var skip = pageSize * (pageIndex - 1);
            long pageCount = (long)Math.Ceiling((decimal)(queryCount / pageSize));

            if (orderBy.ToLower() == "ProductName" && sortOrder.ToLower() == "Ascending")
            {
                retailusers.Items = db.Retailusers.OrderBy(a => a.FirstName).Skip(skip).Take(pageSize).ToList();
            }
            else if (orderBy.ToLower() == "ProductName" && sortOrder.ToLower() == "Descending")
            {
                retailusers.Items = db.Retailusers.OrderByDescending(a => a.FirstName).Skip(skip).Take(pageSize).ToList();
            }
            else if (orderBy.ToLower() == "ProductPrice" && sortOrder.ToLower() == "Ascending")
            {
                retailusers.Items = db.Retailusers.OrderBy(a => a.LastName).Skip(skip).Take(pageSize).ToList();
            }
            else if (orderBy.ToLower() == "ProductPrice" && sortOrder.ToLower() == "Descending")
            {
                retailusers.Items = db.Retailusers.OrderByDescending(a => a.LastName).Skip(skip).Take(pageSize).ToList();
            }

            retailusers.PageCount = pageCount;
            retailusers.QueryCount = queryCount;
            retailusers.PageIndex = pageIndex;
            retailusers.PageSize = pageSize;

            return retailusers;
        }
    }
}
    
