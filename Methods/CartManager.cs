using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class CartManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler. Ürün Sepete Eklendi : " + product.Name);
        }
        public void Add2(string name, string description, double price, int productstock)
        {
            Console.WriteLine("Tebrikler. Ürün Sepete Eklendi : " + name);
        }
    }
}
