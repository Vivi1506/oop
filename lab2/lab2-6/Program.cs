using System;

namespace lab2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter f = new Converter(27.2, 32, 0.35);
            f.ConvertToUSD(27.2);
            f.ConvertUSDtoGRN(2);
            f.ConvertToRUB(10);
            f.ConvertRUBtoGRN(50);
        }
    }
}
