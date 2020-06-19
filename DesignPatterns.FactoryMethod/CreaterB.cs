using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    class CreaterB : Creator
    {
        protected override IProduct FactoryMethod()
        {
            return new ProductB();
        }
    }
}
