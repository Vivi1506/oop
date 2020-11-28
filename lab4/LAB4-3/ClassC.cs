using System;
using System.Collections.Generic;
using System.Text;

namespace LAB4_3
{
    class ClassC : ClassA
    {
        private int __char = '-';
        public int element1 { get; private set; }
        public int element2 { private get; set; }
        public ClassC(char c, char c1, string p1, string p2) : base(p1, p2)
        {
            element1 = c;
            element2 = c1;
        }
        public void Calc(int n)
        {
            Console.WriteLine(__char + element1 + element2);
        }
    }
}
