using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignePatterns.Builder
{
    public class Product
    {
        private List<Object> parts = new List<object>();
        public void Add(string part)
        {
            this.parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this.parts.Count; i++)
            {
                str += this.parts[i] + ", " ;
            }

            str = str.Remove(str.Length - 2); // removing last ",c"

            return "Product parts: " + str + "\n";
        }

    }
}
