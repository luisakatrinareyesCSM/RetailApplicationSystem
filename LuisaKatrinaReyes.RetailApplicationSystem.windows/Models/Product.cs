﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuisaKatrinaReyes.RetailApplicationSystem.windows.Models
{
    class Product
    {
        public Guid? ProductId { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public decimal ProductPrice { get; set; }

        public decimal ProductQuantity { get; set; }
    }
}
