﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignePatterns.AbstractFactory
{
    public interface Ifactory
    {
        IClassA CreateProductA();
        IClassB CreateProductB();


    }
}
