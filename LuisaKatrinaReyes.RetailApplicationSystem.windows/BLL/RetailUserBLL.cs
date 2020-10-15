using LuisaKatrinaReyes.RetailApplicationSystem.windows.Models;
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

        public static List<Retailuser> Search(string orderBy = "LastName", string sortOrder = "Ascending")
        {
            List<Retailuser> retailuser = new List<Retailuser>();
            if (orderBy.ToLower() == "ProductName" && sortOrder.ToLower() == "Ascending")
            {
                retailuser = db.Retailusers.OrderBy(a => a.FirstName).ToList();
            }
            else if (orderBy.ToLower() == "ProductName" && sortOrder.ToLower() == "Descending")
            {
                retailuser = db.Retailusers.OrderByDescending(a => a.FirstName).ToList();
            }
            else if (orderBy.ToLower() == "ProductPrice" && sortOrder.ToLower() == "Ascending")
            {
                retailuser = db.Retailusers.OrderBy(a => a.LastName).ToList();
            }
            else if (orderBy.ToLower() == "ProductPrice" && sortOrder.ToLower() == "Descending")
            {
                retailuser = db.Retailusers.OrderByDescending(a => a.LastName).ToList();
            }
            return retailuser;
        }
    }
}
    
