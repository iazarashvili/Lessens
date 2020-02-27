﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors1
{
    class Point
    {
        private int x, y;

        public int X
        {
            get { return x; }
        }
        public int Y
        {
            get { return y; }
        }
        public Point()
        {
            Console.WriteLine("Default constuctor");
        }

        public Point(int x, int y)
        {
            Console.WriteLine("User Constructor");
            this.x = x;
            this.y = y;
        }
    }
}
