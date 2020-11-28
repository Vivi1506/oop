using System;
using System.Collections.Generic;
using System.Text;

namespace LAB4_2
{
    class C : B
    {
        public int cpd = 0;
        public override void NewBtc(int n1, int n2 = 2, int n3 = 3)
        {
            cpd -= base.__btc;
        }
    }
}
