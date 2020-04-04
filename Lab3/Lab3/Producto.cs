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

        private List<Producto> products;

        private List<Producto> shoppingCart;

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
