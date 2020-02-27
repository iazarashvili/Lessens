using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            Console.WriteLine("Point.X = {0} Point.Y = {1}", point.X , point.Y);

            Console.WriteLine(new string('-', 25));

            Point point1 = new Point(100, 200);
            Console.WriteLine("Point.X = {0} Point.Y = {1}", point1.X, point1.Y);
        }
    }
}
