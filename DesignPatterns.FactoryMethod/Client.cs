using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    class Client
    {
        Creator creator;
     
        public Client(int i)
        {
            
            if (i == 1)
            {
                creator = new CreaterA();
            }
            else
            {
                creator = new CreaterB();
            }
            GetProduct();
        }
         void GetProduct()
        {
            creator.GetObject();
        }
    }
}
