using System;

namespace lab8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateCalculator dateCalculator = new DateCalculator();
            dateCalculator["day"] = 26;
            dateCalculator["month"] = 2;
            dateCalculator["year"] = 21;
            Console.WriteLine(dateCalculator.Check(22, 12, 20));
        }
    }
}
