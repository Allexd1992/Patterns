using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignePatterns.Singltone
{
     class Singltone 
    {
        static Singltone singltone;
        public static Singltone CreateSingltone()
        {
            if (singltone ==null)
            {
                singltone = new Singltone();
                return singltone;
            }
            else
            {
                return singltone;
            }
        }
        public void GetName ()
        {
            Console.WriteLine("Singltone");
        }
        private Singltone() { }
    }
}
