using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LAB4
{
    class ParentClass
    {
        private double __firstArg = 12.5;
        private double __secondArg = 24.6;
        public double Calculation(double firstNum, double secondNum)
        {
            Debug.WriteLine(firstNum + "\t" + secondNum);

            return (firstNum + secondNum) + __firstArg * __secondArg;
        }

    }
}
