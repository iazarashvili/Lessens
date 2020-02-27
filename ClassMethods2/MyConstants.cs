using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods2
{
    class MyConstants
    {
        private double pi = 3.14D;
        private double w = 2.7D;

        public double Pi
        {
            set { pi = value; }
        }
        public double E
        {
            get { return E; }
        }
    }
}
