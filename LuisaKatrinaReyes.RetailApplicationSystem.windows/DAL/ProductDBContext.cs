using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuisaKatrinaReyes.RetailApplicationSystem.windows.DAL
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext() : base("myConnectionString")
        {
            Database.SetInitializer(new LuisaKatrinaReyes.RetailApplicationSystem.windows.DAL.ProductDataInitializer());
        }

        public DbSet<Models.Product> Product { get; set; }
    }
}
