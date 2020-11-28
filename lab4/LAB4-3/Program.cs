using System;
using System.Diagnostics;

namespace LAB4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassA a = new ClassA("Vi", "vi");
            ClassB b = new ClassB("v", "i", 18);
            b.Calc(3);
            Debug.WriteLine(b.num2);
            Debug.WriteLine(b.num1);
        }
    }
}
