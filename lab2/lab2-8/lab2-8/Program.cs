using System;

namespace lab2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice f = new Invoice(102, "BorMax", "Monobank", "a232", 3);
            f.ShowAllInfo();
        }
    }
}
