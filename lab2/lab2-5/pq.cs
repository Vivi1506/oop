using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_5
{
    class User
    {
        public string login {get;set;}
        public string firstName { get; set; }
        public string secondName { get; set; }
        public int age { get; set; }
        public string dateOfRegister { get; private set; }

        public User(string date)
        {
            dateOfRegister = date;
        }
        public void ShowAllInfo()
        {

            Console.WriteLine(login);
            Console.WriteLine(firstName);
            Console.WriteLine(secondName);
            Console.WriteLine(age);
            Console.WriteLine(dateOfRegister);

        }

    }
}
