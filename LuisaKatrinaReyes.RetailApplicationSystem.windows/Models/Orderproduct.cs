using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuisaKatrinaReyes.RetailApplicationSystem.windows.Models
{
    public class Orderproduct
    {
        public Guid? OrderProductId { get; set; }

        public Guid? OrderId { get; set; }

        public DateTime DateTime { get; set; }

        public Guid? CustomerId { get; set; }

        public string CustomerName { get; set; }

        public Guid? ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }

        public decimal ProductQuantity { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
