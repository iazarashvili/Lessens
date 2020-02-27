using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor2
{
    class Point
    {
        private int x, y;
        private string name;

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }
        public string Name
        {
            get { return name; }
        }

        public Point(int x, int y)
        {
            Console.WriteLine("Constructor users");
            this.x = x;
            this.y = y;
        }

        public Point(string name) : this(300, 400)
        {
            Console.WriteLine("Constructor 1 parametrs");
            this.name = name;
        }

    }
}
