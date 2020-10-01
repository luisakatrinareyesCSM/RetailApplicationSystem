using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuisaKatrinaReyes.RetailApplicationSystem.windows.Models
{
    class Retailuser
    {
        public Guid? Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal ContactNumber { get; set; }

        public string EmailAddress { get; set; }

    }
}
