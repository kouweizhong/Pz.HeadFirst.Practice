﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 抽象工厂模式.SourceFactory;

namespace 抽象工厂模式.Pizza
{
    public class Pizza
    {
        public string PizzaName { get; set; }
        public abstract void Prapare();
    }
}
