﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuisaKatrinaReyes.RetailApplicationSystem.windows.Models
{
    public class Customer
    {
        public Guid? Id { get; set; }

        public string CustomerName { get; set; }

        public decimal Customer_ContactNumber { get; set; }

        public string Customer_EmailAddress { get; set; }

        public string BillingAddress { get; set; }

        public string Default_ShippingAddress { get; set; }
    }
}
