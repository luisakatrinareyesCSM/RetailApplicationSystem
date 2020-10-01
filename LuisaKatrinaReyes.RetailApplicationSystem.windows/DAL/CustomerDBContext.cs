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

        }

        public DbSet<Models.Customer> Customer { get; set; }
    }
}
