using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessens3
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();

            var listNumber = new List<int>()
            {
                1,
                2,
                3
            };

            for (int i = 4; i < 10; i++)
            {
                listNumber.Add(i);
            }
            Console.WriteLine(listNumber.Count);

            listNumber.Remove(1);

            if (listNumber.Contains(1))
            {
                Console.WriteLine("true " + listNumber.IndexOf(1));
            }
            Console.WriteLine("number deleted");


        }
    }
}
