using LuisaKatrinaReyes.RetailApplicationSystem.windows.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuisaKatrinaReyes.RetailApplicationSystem.windows.DAL
{
    public class RetailuserDBContext : DbContext 
    {
        public RetailuserDBContext() : base("myConnectionString")
        {
            Database.SetInitializer(new LuisaKatrinaReyes.RetailApplicationSystem.windows.DAL.RetailuserDataInitializer());
        }

        public RetailuserDBContext(DbSet<Retailuser> retailusers)
        {
            Retailusers = retailusers;
        }

        public DbSet<Models.Retailuser> Retailusers { get; set; }
    }
}
