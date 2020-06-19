using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignePatterns.AbstractFactory
{
    class Client
    {
        Ifactory factory;
        IClassA classA;
        IClassB classB;
        public  Client()
        {
            Console.WriteLine("type? 1/2: ");
            int i = int.Parse(Console.ReadLine());
            if (i==1)
            {
                factory = new Factory1();
            }
            else
            {
                factory = new Factory2();
            }
            factory.CreateProductA().GetName();       
            classB = factory.CreateProductB();
            classB.GetName();
        }

    }
}
