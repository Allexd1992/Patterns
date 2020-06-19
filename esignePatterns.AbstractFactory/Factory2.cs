using DesignePatterns.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignePatterns.AbstractFactory
{
    class Factory2 : Ifactory
    {
        public IClassA CreateProductA()
        {
            return new ClassA2();
        }

        public IClassB CreateProductB()
        {
            return new ClassB2();
        }
    }
}
