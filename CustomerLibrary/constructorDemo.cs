﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLibrary
{
    public class constructorDemo
    {
        public CustType MyCustType { get; set; }
        public constructorDemo(CustType custType)
        {
            this.MyCustType = custType; 
        }
    }
}
