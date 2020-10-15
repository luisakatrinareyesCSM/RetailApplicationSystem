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
            context.Products.Add(new Models.Product()
            {
                Id = Guid.Parse("7c222960-485c-497b-9ae4-f293d1b73e22"),
                ProductName = "Silver Mirror Square",
                Description = "9Pcs Room Bathroom Adhesive Mirror Square Silver Self Sticker Tile Decor Wall Lot 15x15cm",
                ProductPrice = Decimal.Parse("220.00"),
                ProductQuantity = Decimal.Parse("100")
            });

            context.Products.Add(new Models.Product()
            {
                Id = Guid.Parse("95500128-2f78-41e3-a6df-b34f47ddb499"),
                ProductName = "Christmas Lantern",
                Description = "Christmas Hanging Prop Led Candles Light Santa claus elk snowman Lantern Flame Lamp Party Supplies",
                ProductPrice = Decimal.Parse("250.00"),
                ProductQuantity = Decimal.Parse("100")
            });

            context.Products.Add(new Models.Product()
            {
                Id = Guid.Parse("17f3263f-958b-47e2-9bff-ec692c94dd05"),
                ProductName = "Jelly Gel Bead",
                Description = "2000Pcs Water Balls Jelly Gel Bead for Plates Refill Colors" +
                "Colors: white, purple,blue, green, black,clear,mixed color",
                ProductPrice = Decimal.Parse("150"),
                ProductQuantity = Decimal.Parse("100")
            });

            context.Products.Add(new Models.Product()
            {
                Id = Guid.Parse("c3505155-ccad-4556-8800-3b7531753b88"),
                ProductName = "2pcs Drawstring Bag",
                Description = "2pcs Waterproof Non-woven Drawstring Bag Shoe Clothes Storage Bag" +
                " Colors: white, black,gray,rose,dark blue,orange",
                ProductPrice = Decimal.Parse("100.00"),
                ProductQuantity = Decimal.Parse("100")
            });

            context.Products.Add(new Models.Product()
            {
                Id = Guid.Parse("9a864c37-0207-45ad-be9a-4646304426ce"),
                ProductName = "2pcs LED Light",
                Description = "2pcs LED Lamp Flash Tyre Wheel Valve Cap Light" +
                "Color: pink,blue,green,yellow",
                ProductPrice = Decimal.Parse("120.00"),
                ProductQuantity = Decimal.Parse("100")
            });

            context.Products.Add(new Models.Product()
            {
                Id = Guid.Parse("d612e9a8-cc66-4944-9412-6bf5c204d4d1"),
                ProductName = "8pcs/Set of Notebook",
                Description = "It comes with different colors" +
                "Color: pink,blue,green,yellow,orange,red,brown,black",
                ProductPrice = Decimal.Parse("100.00"),
                ProductQuantity = Decimal.Parse("100")
            });

            context.Products.Add(new Models.Product()
            {
                Id = Guid.Parse("b223c829-173e-48f7-a286-db79ac98b665"),
                ProductName = "Mickey Mouse Shirt",
                Description = "Size is Small_Medium but it is Superstretch" +
                "Color: White Shirt",
                ProductPrice = Decimal.Parse("200.00"),
                ProductQuantity = Decimal.Parse("100")
            });

            context.Products.Add(new Models.Product()
            {
                Id = Guid.Parse("878009b7-ab48-4bb0-89d3-a13726309a01"),
                ProductName = "Vaseline Lip Therapy",
                Description = "this is 7g in a small bottle",
                ProductPrice = Decimal.Parse("50.00"),
                ProductQuantity = Decimal.Parse("100")
            });

            context.Products.Add(new Models.Product()
            {
                Id = Guid.Parse("c8fae28e-c58a-4b02-8db9-f14557e343ce"),
                ProductName = "BTS Poster",
                Description = "Size: A3 (larger than A4 Bond paper" +
                            "Design Color Theme: Pink,Green,Blue,Orange,Black,Red",
                ProductPrice = Decimal.Parse("25.00"),
                ProductQuantity = Decimal.Parse("100")
            });

            context.Products.Add(new Models.Product()
            {
                Id = Guid.Parse("a923a825-1b5d-4073-8fb7-0acc3ac1040d"),
                ProductName = "Mini Misquitto Killer",
                Description = "It is Electric Killer in small size" +
                            "Color:Pink,Blue,Yellow,Green",
                ProductPrice = Decimal.Parse("120.00"),
                ProductQuantity = Decimal.Parse("100")
            });

            context.Products.Add(new Models.Product()
            {
                Id = Guid.Parse("947a417c-b7a1-4cda-9ff8-60ae13b2e74d"),
                ProductName = "Anti-rad Transparent Eyeglasses",
                Description = "Only Transparent color available",
                ProductPrice = Decimal.Parse("200.00"),
                ProductQuantity = Decimal.Parse("100")
            });

            context.Products.Add(new Models.Product()
            {
                Id = Guid.Parse("2283525c-bad9-4a97-9903-88fbe5b7479b"),
                ProductName = "Eyebrow/Eyeliner Pencil with Concealer ",
                Description = "The eyeliner/eyebrow pencil is color brown",
                ProductPrice = Decimal.Parse("50.00"),
                ProductQuantity = Decimal.Parse("100")
            });

            context.Products.Add(new Models.Product()
            {
                Id = Guid.Parse("e8680763-ec58-477e-8196-199c01a82e71"),
                ProductName = "Aloevera Clear Lipstick",
                Description = "Aloevera 99%",
                ProductPrice = Decimal.Parse("50.00"),
                ProductQuantity = Decimal.Parse("100")
            });

            context.Products.Add(new Models.Product()
            {
                Id = Guid.Parse("bca5cbeb-d5bc-46cd-99ee-555815485caa"),
                ProductName = "Clay Blush 10g",
                Description = "Sunkissed, Autumn, Champagne",
                ProductPrice = Decimal.Parse("50.00"),
                ProductQuantity = Decimal.Parse("100")
            });

            context.Products.Add(new Models.Product()
            {
                Id = Guid.Parse("1296f1c1-7dbd-4582-929c-b8b68a15a13e"),
                ProductName = "Disposable Mask",
                Description = "It is 3ply mask and it has 50pcs/box" + "it is sealed",
                ProductPrice = Decimal.Parse("120.00"),
                ProductQuantity = Decimal.Parse("100")
            });

            context.Products.Add(new Models.Product()
            {
                Id = Guid.Parse("92eb39f9-5b91-48cf-8871-5cb03aafc1d2"),
                ProductName = "1080px of Webcam",
                Description = "It comes with microphone" +
                            "Color: bLack,red,orange,blue,silve,gold",
                ProductPrice = Decimal.Parse("1,200.00"),
                ProductQuantity = Decimal.Parse("100")
            });

            context.Products.Add(new Models.Product()
            {
                Id = Guid.Parse("d68cdffb-817d-4ae1-b370-7f37b267f885"),
                ProductName = "Bennie Bonnet",
                Description = "It comes with different colors" +
                            "Color: hot pink,dark blue,neongreen,banana yellow,neon orange,red,brown,black,maroon",
                ProductPrice = Decimal.Parse("130.00"),
                ProductQuantity = Decimal.Parse("100")
            });

            context.Products.Add(new Models.Product()
            {
                Id = Guid.Parse("4eba8c68-fcb4-4f25-9217-b4dfc16e594d"),
                ProductName = "Chill Croptop Freesize",
                Description = "It comes with different colors" +
                            "Color: oldrose, red, maroon, black, white",
                ProductPrice = Decimal.Parse("130.00"),
                ProductQuantity = Decimal.Parse("100")
            });

            context.Products.Add(new Models.Product()
            {
                Id = Guid.Parse("6176216a-5774-485b-bc2e-121231a38b89"),
                ProductName = "Netflix Croptop Freesize",
                Description = "It comes with different colors" +
                            "Color: oldrose, red, maroon, black, white",
                ProductPrice = Decimal.Parse("130.00"),
                ProductQuantity = Decimal.Parse("100")
            });

            context.Products.Add(new Models.Product()
            {
                Id = Guid.Parse("a3e20ecc-53d4-4e8d-b02b-65df0c52d258"),
                ProductName = "Keyboard with Mouse",
                Description = "It comes with Light different colors" +
                            "Color: pink,blue,green,yellow,orange,red,brown,black,Colorful",
                ProductPrice = Decimal.Parse("750.00"),
                ProductQuantity = Decimal.Parse("100")
            });

            context.Products.Add(new Models.Product()
            {
                Id = Guid.Parse("ec621405-6d8b-4e05-be2b-b2b4b6e36f0d"),
                ProductName = "1 rim bond paper",
                Description = "Size: Short, A4, Long",
                ProductPrice = Decimal.Parse("200.00"),
                ProductQuantity = Decimal.Parse("100")
            });

            context.Products.Add(new Models.Product()
            {
                Id = Guid.Parse("2ca3e4d4-dbc3-4fa1-b04f-f5e05f756c18"),
                ProductName = "5pcs/set Sesame street socks",
                Description = "It comes with different colors" +
                            "Color: red,white,yellow,green,black",
                ProductPrice = Decimal.Parse("130.00"),
                ProductQuantity = Decimal.Parse("100")
            });

            context.Products.Add(new Models.Product()
            {
                Id = Guid.Parse("24679ea8-a69b-4cbf-9b92-483a0d246e1f"),
                ProductName = "10pccs/set Bear socks",
                Description = "It comes with different colors" +
                            "Color: red,white,yellow,green,black",
                ProductPrice = Decimal.Parse("170.00"),
                ProductQuantity = Decimal.Parse("100")
            });

            context.Products.Add(new Models.Product()
            {
                Id = Guid.Parse("de60f9c3-ce51-446c-b151-4c741a306d8f"),
                ProductName = "2pcs/ set Sportsband",
                Description = "It comes with different colors" +
                            "Color: blue,black,red,pink,orange,maroon,army green,beige,white",
                ProductPrice = Decimal.Parse("70.00"),
                ProductQuantity = Decimal.Parse("100")
            });

            context.Products.Add(new Models.Product()
            {
                Id = Guid.Parse("10af129d-6e6a-4b4e-8546-f903ed8b73d6"),
                ProductName = "automatic Bear Umbrella",
                Description = "It comes with different colors and 10inch in size" +
                            "Color: black,white,yellow,blue,red",
                ProductPrice = Decimal.Parse("150.00"),
                ProductQuantity = Decimal.Parse("100")
            });

            context.Products.Add(new Models.Product()
            {
                Id = Guid.Parse("eaa6a819-f6e7-425f-9c29-39de71879ff4"),
                ProductName = "Hanabishi Stand Mixer HHMB-1600SS 3.5L",
                Description = "Feature: capacity 3.5Liter, Stainless steel mixung bowl, 5speed control with turbo function" +
                            "Feature: Self-rotation mixing bowl, one touch easy beater ejector, chrome plated beater & dough hooks" +
                            "Information: 230V~ Voltage, 60Hz Frequency, 386*248*252mm in packaging size, 330*220*340mm unit dimension" +
                            "Color: black, white, silver, gold, maroon",
                ProductPrice = Decimal.Parse("2,200.00"),
                ProductQuantity = Decimal.Parse("100")
            });

            context.Products.Add(new Models.Product()
            {
                Id = Guid.Parse("58f27194-f12b-49c3-945d-f9ac5317ba35"),
                ProductName = "Cath Kidston Purse",
                Description = "It comes with different colors" +
                            "with card holder, money space, picture space, and zipper space for coins" +
                            "Color: pink,blue,green,yellow,orange,red,brown,black",
                ProductPrice = Decimal.Parse("140.00"),
                ProductQuantity = Decimal.Parse("100")
            });

            context.Products.Add(new Models.Product()
            {
                Id = Guid.Parse("ba2056b7-cd44-4638-8831-e87ddf4e4358"),
                ProductName = "Moder Hanger",
                Description = "It saves space on your cabinet and give you a modern pattern for your closet" +
                            "Color: gray, black, mint, hotpink, darkblue, white",
                ProductPrice = Decimal.Parse("40.00"),
                ProductQuantity = Decimal.Parse("100")
            });

            context.Products.Add(new Models.Product()
            {
                Id = Guid.Parse("4256d8e0-90e7-405a-8c4d-1067b84659ec"),
                ProductName = "Cake turntable",
                Description = "Size id 12*12*4 Inches" +
                            "Color: black, white, light pink, gray, blue",
                ProductPrice = Decimal.Parse("260.00"),
                ProductQuantity = Decimal.Parse("100")
            });

            context.Products.Add(new Models.Product()
            {
                Id = Guid.Parse("77274f5a-f7bd-40a7-9629-3d5536703e6e"),
                ProductName = "Linkbitz Bluetooth Speaker RFR-203",
                Description = "Size is 14*8*5 inch" +
                            "feature: USB, FM, Music, LED Light, Bluetooth, Microphone" +
                            "Color: pink,blue,green,yellow,orange,red,brown,black",
                ProductPrice = Decimal.Parse("1,300.00"),
                ProductQuantity = Decimal.Parse("100")
            });


        }
    }
}
