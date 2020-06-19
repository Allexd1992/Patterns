using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignePatterns.AbstractFactory
{
    class Factory1 : Ifactory
    { 

        public IClassA CreateProductA()
        {
            return new ClassA1();
        }

        public IClassB CreateProductB()
        {
            return new ClassB1();
        }
    }
}
