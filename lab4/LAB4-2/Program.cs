using System;

namespace LAB4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            A a = new A(b);
            C b1 = new C();
            b1.NewBtc(3, 6);

        }
    }
}
