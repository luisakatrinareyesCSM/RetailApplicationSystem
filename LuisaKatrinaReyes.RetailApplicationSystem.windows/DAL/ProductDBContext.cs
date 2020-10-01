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

        }

        public DbSet<Models.Product> Product { get; set; }
    }
}
