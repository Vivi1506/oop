using System;
using System.Collections.Generic;
using System.Text;

namespace LAB4_2
{
    class B 
    {
        public string name = "Bob";
        public int __btc = 1;
        public B() 
        {
            Console.WriteLine();

        }
        public virtual void NewBtc(int n1, int n2 = 2, int n3 = 3)
        {
            __btc++;
        }
    }
}
