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
        public string Brand { get => brand; set => brand= value; }

    }
}
