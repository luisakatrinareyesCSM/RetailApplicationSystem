using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuisaKatrinaReyes.RetailApplicationSystem.windows.DAL
{
    public class CustomerDBContext : DbContext
    {
        public CustomerDBContext() : base("myConnectionString")
        {
            Database.SetInitializer(new LuisaKatrinaReyes.RetailApplicationSystem.windows.DAL.CustomerDataInitializer());
        }

        public DbSet<Models.Customer> Customers { get; set; }
    }
}
