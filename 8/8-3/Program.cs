using System;

namespace lab8_3
{
    class Program
    {
        static void Main(string[] args)
        {
           A a = new A();
           B b = new B();
           a[0] = 'i';
           a[1] = 'p';
            b[0] = 89;
           foreach (var k in a.length)
           {
               Console.WriteLine(k);
           }
           

        }
    }
}
