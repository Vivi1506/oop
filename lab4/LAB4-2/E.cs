using System;
using System.Collections.Generic;
using System.Text;

namespace LAB4_2
{
    class E : B
    {
        public int time = 0;
        public override void NewBtc(int n1, int n2 = 2, int n3 = 3)
        {
            time += base.__btc + n1;
        }
    }
}
