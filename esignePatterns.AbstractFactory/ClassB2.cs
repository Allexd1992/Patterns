using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignePatterns.AbstractFactory
{
    class ClassB2 : IClassB
    {
        public  void GetName()
        {
            Console.WriteLine("Class B2");
        }
    }
}
