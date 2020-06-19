using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    abstract class Creator
    {
        protected abstract IProduct FactoryMethod();
        public void GetObject()
        {
           var product= FactoryMethod();
            Console.WriteLine(product.getWorld());
        }

    }
}
