using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignePatterns.Builder
{
    public interface IBuilder
    {
        void Reset();
        void BuildStepA();
        void BuildStepB();
        void BuildStepC();


    }
   
}
