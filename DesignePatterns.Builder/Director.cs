using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignePatterns.Builder
{
    public class Director
    {
        private IBuilder builder;

        public IBuilder Builder
        {
            set { builder = value; }
        }

        // Директор может строить несколько вариаций продукта, используя
        // одинаковые шаги построения.
        public void buildMinimalViableProduct()
        {
            this.builder.BuildStepA();
        }

        public void buildFullFeaturedProduct()
        {
            this.builder.BuildStepA();
            this.builder.BuildStepB();
            this.builder.BuildStepC();
        }
    }
}
