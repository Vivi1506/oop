using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_6
{
    class Converter
    {


        public double USD { get; set; }
        public double EUR { get; set; }
        public double RUB { get; set; }
        public Converter(double usd, double eur, double rub)
        {
            USD = usd;
            EUR = eur;
            RUB = rub;
        }
        public void ConvertToUSD(double grn)
        {
            double result = grn / USD;
            Console.WriteLine(result);
        }
        public void ConvertToEUR(double grn)
        {
            double result = grn / EUR;
            Console.WriteLine(result);
        }
        public void ConvertToRUB(double grn)
        {
            double result = grn / RUB;
            Console.WriteLine(result);
        }
        public void ConvertUSDtoGRN(double usd)
        {
            double result = usd * USD;
            Console.WriteLine(result);
        }
        public void ConvertEURtoGRN(double eur)
        {
            double result = eur * EUR;
            Console.WriteLine(result);
        }
        public void ConvertRUBtoGRN(double rub)
        {
            double result = rub * RUB;
            Console.WriteLine(result);
        }

    }
}
