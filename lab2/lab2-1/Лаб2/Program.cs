using System;

namespace Лаб2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Address myAdress = new Address();
            myAdress.Index  = "25005";
            Console.WriteLine(myAdress.Index);
            Console.ReadLine();
        }
    }
}
