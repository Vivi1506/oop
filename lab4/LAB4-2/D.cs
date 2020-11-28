using System;
using System.Collections.Generic;
using System.Text;

namespace LAB4_2
{
    class D : B
    {
        public int Money = 2;
        public override void NewBtc(int n1, int n2 = 2, int n3 = 3)
        {
            Money += base.__btc;
        }
    }
}
