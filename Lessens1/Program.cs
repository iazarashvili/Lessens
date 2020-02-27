using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessens1
{
    class Program
    {
        public struct Point {
            public int X { get; set; }
            public int Y {get; set;}

            public void Draw()
            {
                Console.WriteLine(X + " , " + Y);
            }
        }
        static void Main(string[] args)
        {
            var point = new Point();
            point.X = 5;
            point.Y = 7;
            point.Draw();

          
        }
    }
}
