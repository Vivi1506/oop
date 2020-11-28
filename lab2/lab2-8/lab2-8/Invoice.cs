using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_8
{
    class Invoice
    {

        public int account { get; private set; }
        public string customer { get; private set; }
        public string provider { get; private set; }
        private string article;
        private int quantity;
        private int price = 25;
        private double _priceWithNDS;
        private double _priceWithoutNDS;
        public Invoice(int akk, string cust, string prov, string artcl, int quan)
        {
            akk = account;
            customer = cust;
            provider = prov;
            article = artcl;
            quantity = quan;

        }
        public void PriceNoNDS()
        {
            _priceWithoutNDS = (price * 0.80) * quantity;
            
        }
        public void PriceNDS()
        {
           _priceWithNDS =  price * quantity;
        }
        public void ShowAllInfo()
        {
            Console.WriteLine(account);
            Console.WriteLine(customer);
            Console.WriteLine(provider);
            Console.WriteLine(article);
            Console.WriteLine(quantity);
            Console.WriteLine(_priceWithoutNDS);
            Console.WriteLine(_priceWithNDS);
        }



    }
}
