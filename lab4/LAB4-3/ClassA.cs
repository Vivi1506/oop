using System;
using System.Collections.Generic;
using System.Text;

namespace LAB4_3
{
    class ClassA
    {
        public string s1 { get; private set;}
        public string s2 { get; set; }
        public ClassA(string p1, string p2)
        {
            s1 = p1;
            s2 = p2;
        }
    }
}
