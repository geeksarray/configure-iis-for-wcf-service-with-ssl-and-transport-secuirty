using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NorthwindClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductServiceRef.ProductsClient client = new ProductServiceRef.ProductsClient();
            string category = client.GetCategoryName(1);
            string name = client.GetProductName(1);
            int qty = client.GetProductQty(1);
            Console.WriteLine("Product Name : " + name);
            Console.WriteLine("Product Qty : " + qty.ToString());
            Console.WriteLine("Product Category : " + category);
            Console.Read();
        }
    }
}
