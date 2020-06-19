using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignePatterns.Singltone
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Singltone.CreateSingltone();
            a.GetName();
            Console.WriteLine(a.GetHashCode());
            var b = Singltone.CreateSingltone();
            b.GetName();
            Console.WriteLine(b.GetHashCode());
            Console.ReadLine();
            
        }
    }
}
