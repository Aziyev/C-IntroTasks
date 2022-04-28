using System;
using System.Collections.Generic;
using System.Text;

namespace homewworkss2
{
    internal class Qelem : Product
    {
        public double Weight { get; set; }  

        public double color { get; set; } 

        public Qelem(string name) : base(name)
        {

        }
    }
}
