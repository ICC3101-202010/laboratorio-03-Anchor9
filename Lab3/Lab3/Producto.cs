using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Producto
    {
        private string name;
        private int stock;
        private int price;
        private string brand;
        private List<Producto> productos;

        public Producto()
        {


        }

        public Producto(string Name, int Stock, string Brand, int Price)
        {
            name = Name;
            stock = Stock;
            price = Price;
            brand = Brand;

        }
        public string Name { get => name; set => name = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Price { get => price; set => price = value; }
        public string Brand { get => brand; set => brand = value; }

        public List<Producto> Products { get => productos; set => productos = value; }

        public List<Producto> Market = new List<Producto>();

        public void MarketList()
        {
            //Products by defect

            Producto Chips = new Producto("Chips", 10, "Lays", 1000);                   //1
            Producto Yogurt = new Producto("Yogurt", 15, "Nestle", 150);                //2
            Producto Coffe = new Producto("Coffe", 8, "Nescafe", 900);                  //3
            Producto Water = new Producto("Mineral Water", 20, "Lays", 500);            //4
            Producto Soda = new Producto("Sprite", 8, "Sprite", 1000);                  //5
            Producto Noodle = new Producto("Spagetti", 17, "Carozzi", 450);             //6
            Producto Tea = new Producto("Ceylan Tea", 12, "Akbar", 800);                //7
            Producto Shampoo = new Producto("Shampoo", 5, "Familand", 2500);            //8
            Producto Cheese = new Producto("Chedar chease", 13, "La vaquita", 3000);    //9
            Producto Muffin = new Producto("Muffin", 15, "Marinela", 900);              //10
            Producto Bread = new Producto("Bread", 20, "Bimbo", 1200);                  //11
            Producto Rice = new Producto("Rice", 15, "Tucapel", 600);                   //12
            Producto TV = new Producto("Smart TV", 3, "LG", 4000000);                  //13
            Producto Egss = new Producto("Happy Eggs", 30, "Farm", 3000);               //14
            Producto Sugar = new Producto("Sugar", 10, "Iansa", 400);                   //15
            Producto Bateries = new Producto("Alcalines", 10, "Duracell", 1500);        //16
            Producto Book = new Producto("Notebook", 10, "Torre", 1000);                //17
            
            Market.Add(Chips);
            foreach (var product in Market)
            {
                Console.WriteLine(product.Name + product.brand);
            }


        }


        public void ShopList(Producto producto)
        {
            string new_name = producto.Name;
            int new_stock = producto.Stock;
            int new_price = producto.Price;
            string new_brand = producto.Brand;

            List<Producto> shoppingCart = new List<Producto>();
            shoppingCart.Add(new Producto(new_name, new_stock, new_brand, new_price));

        }




 
            

    }
}
