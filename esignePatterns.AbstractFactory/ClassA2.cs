﻿using DesignePatterns.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignePatterns.AbstractFactory
{
    class ClassA2 : IClassA
    {
        public void GetName()
        {
            Console.WriteLine("Class A2");
        }
    }
}
