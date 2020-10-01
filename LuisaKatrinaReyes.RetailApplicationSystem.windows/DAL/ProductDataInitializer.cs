using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuisaKatrinaReyes.RetailApplicationSystem.windows.DAL
{
    public class ProductDataInitializer : System.Data.Entity.DropCreateDatabaseAlways<ProductDBContext>
    {
        protected override void Seed(ProductDBContext context)
        {
            context.Product.Add(new Models.Product()
            {
                Id = Guid.Parse("7c222960-485c-497b-9ae4-f293d1b73e22"),
                ProductName = "Silver Mirror Square",
                Description = "9Pcs Room Bathroom Adhesive Mirror Square Silver Self Sticker Tile Decor Wall Lot 15x15cm",
                ProductPrice = Decimal.Parse("220.00"),
                ProductQuantity = Decimal.Parse("10")
            });

            context.Product.Add(new Models.Product()
            {
                Id = Guid.Parse("95500128-2f78-41e3-a6df-b34f47ddb499"),
                ProductName = "Christmas Lantern",
                Description = "Christmas Hanging Prop Led Candles Light Santa claus elk snowman Lantern Flame Lamp Party Supplies",
                ProductPrice = Decimal.Parse("250.00"),
                ProductQuantity = Decimal.Parse("10")
            });

            context.Product.Add(new Models.Product()
            {
                Id = Guid.Parse("17f3263f-958b-47e2-9bff-ec692c94dd05"),
                ProductName = "Jelly Gel Bead",
                Description = "2000Pcs Water Balls Jelly Gel Bead for Plates Refill Colors" +
                "Colors: white, purple,blue, green, black,clear,mixed color",
                ProductPrice = Decimal.Parse("150"),
                ProductQuantity = Decimal.Parse("10")
            });

            context.Product.Add(new Models.Product()
            {
                Id = Guid.Parse("c3505155-ccad-4556-8800-3b7531753b88"),
                ProductName = "2pcs Drawstring Bag",
                Description = "2pcs Waterproof Non-woven Drawstring Bag Shoe Clothes Storage Bag" +
                " Colors: white, black,gray,rose,dark blue,orange",
                ProductPrice = Decimal.Parse("100.00"),
                ProductQuantity = Decimal.Parse("10")
            });

            context.Product.Add(new Models.Product()
            {
                Id = Guid.Parse("9a864c37-0207-45ad-be9a-4646304426ce"),
                ProductName = "2pcs LED Light",
                Description = "2pcs LED Lamp Flash Tyre Wheel Valve Cap Light" +
                "Color: pink,blue,green,yellow",
                ProductPrice = Decimal.Parse("120.00"),
                ProductQuantity = Decimal.Parse("10")
            });
        }
    }
}
