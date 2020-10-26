using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LuisaKatrinaReyes.RetailApplicationSystem.windows.DAL
{
    public class RetailuserDataInitializer : System.Data.Entity.DropCreateDatabaseAlways<RetailuserDBContext>
    {
        protected override void Seed(RetailuserDBContext context)
        {
            context.Retailusers.Add(new Models.Retailuser()
            {
                Id = Guid.Parse("0078f08c-6a57-46ec-ba8b-88b62ba55811"),
                FirstName = "Izzel Kate",
                LastName = "Reyes",
                ContactNumber = Decimal.Parse("09309571564"),
                EmailAddress = "izzelkatereyes@gmail.com"
            });

            context.Retailusers.Add(new Models.Retailuser()
            {
                Id = Guid.Parse("ef7c0e50-abc7-4ec4-a1bb-484e9d2f9a4c"),
                FirstName = "Luisa Katrina",
                LastName = "Reyes",
                ContactNumber = Decimal.Parse("09090621797"),
                EmailAddress = "luisakatrinareyes@gmail.com"
            });

            context.Retailusers.Add(new Models.Retailuser()
            {
                Id = Guid.Parse("e2a8909d-3ea3-4db4-8296-2fe4fbb8b3b6"),
                FirstName = "Leoj Ibsen",
                LastName = "Reyes",
                ContactNumber = Decimal.Parse("09564905703"),
                EmailAddress = "leojibsenreyes@gmail.com"
            });

            context.Retailusers.Add(new Models.Retailuser()
            {
                Id = Guid.Parse("baa3cf5a-58b0-42f4-8c11-15346ccd94e0"),
                FirstName = "Liza",
                LastName = "Reyes",
                ContactNumber = Decimal.Parse("09071969070"),
                EmailAddress = "lizapangilinanreyes@gmail.com"
            });

            context.Retailusers.Add(new Models.Retailuser()
            {
                Id = Guid.Parse("c54b675b-da6b-4f4b-9d69-8b6bcae3979e"),
                FirstName = "Joel",
                LastName = "Reyes",
                ContactNumber = Decimal.Parse("09502801814"),
                EmailAddress = "joeladrianoreyes@gmail.com"
            });

            context.SaveChanges();
        }
    }
}
