using System;
using System.Linq;

namespace lab8_3
{
    public class A : B
    {
        private char[] arr = new char[]{'1', 'd'};

        public int[] length
        {
            get
            {
                return new int[]{arr.Length, base.Length};
            }
        }
        public char this[char index]
        {
            get
            {
                return arr[Array.IndexOf(arr, index)];
            }
            set
            {
                arr[Array.IndexOf(arr, index)] = value;
            }

        }
    }
}