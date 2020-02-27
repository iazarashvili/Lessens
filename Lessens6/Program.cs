using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessens6
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "ilia";
            string surname = "azarashvili";

            var newString = name.Replace('i', 'a');

            Console.WriteLine(newString);

            var mystring = new StringBuilder();
            mystring.Append("aq shevcvlit  asoebs");
            mystring.Replace('i', 'g');

            Console.WriteLine(mystring);
        }
    }
}
