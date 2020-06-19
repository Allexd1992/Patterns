using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    class ProductA : IProduct
    {
        public ProductA()
        {
            Console.WriteLine("Product A is created");
        }
        public string getWorld()
        {
            return "ProductA";
        }
    }
}
