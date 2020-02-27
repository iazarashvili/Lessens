using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyConstants myclass = new MyConstants();

            myclass.Pi = 3.14159265D;

            Console.WriteLine("e = {0}", myclass.E);

        }
    }
}
