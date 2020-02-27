using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessensLinq2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "ilia", "giorgi", "beqa", "tedi" };

            var myLinqQuery = from name in names
                              where name.Contains('g')
                              select name;

            foreach (var name in myLinqQuery)
            {
                Console.WriteLine(name + " ");
            }
        }
    }
}
