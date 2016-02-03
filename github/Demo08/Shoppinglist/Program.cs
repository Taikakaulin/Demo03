using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppinglist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> product = new List<Product>();
            product.Add(new Product { Item = "Whisky ", Price = "67.45" });
            product.Add(new Product { Item = "Bread ", Price = "2.45" });
            product.Add(new Product { Item = "Tomato ", Price = "4.67" });
            Console.Write("All products in collection: \n");
            foreach(Product k in product)
            {
                Console.WriteLine("-"+ k.Item + k.Price);
            }
        }
    }
}
