using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_4
{
    class Point
    {

        public int x { get; private set; }
        public int y { get; private set; }
        public string name { get; private set; }
        public Point(int x, int y, string name)
        {
           this.x = x;
            this.y = y;
            this.name = name;
        

        }
    }
}
