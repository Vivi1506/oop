using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_7
{
    class Employee
    {
        public string positions { get; private set; }
        public string firstName { get; private set; }
        public string secondName { get; private set; }
        public double zp { get; private set; }
        public double nalog { get; private set; }

        public Employee(string name1, string name2)
        {
            firstName = name1;
            secondName = name2;
        }
        public void Otklad(int position, int exp)
        {

            double cof = 1 + (0.1 * exp);
            switch (position)
            {
                case 1:
                    {
                        zp = 5000 * cof;
                        positions = "офисный работник";
                        break;

                    }
                case 2:
                    {
                        zp = 7500 * cof;
                        positions = "глава отдела";
                        break;
                    }
                case 3:
                    {
                        zp = 9000 * cof;
                        positions = "зам. начальника";
                        break;

                    }
                case 4:
                    {
                        zp = 15000 * cof;
                        positions = "Начальник";
                        break;
                    }
            }

        }
        public void Nalog()
        {
            nalog = zp * 0.06;

        }
        public void ShowAllInfo()
        {
            Console.WriteLine(firstName);
            Console.WriteLine(secondName);
            Console.WriteLine(positions);
            Console.WriteLine(zp);
            Console.WriteLine(nalog);
        
        
        }

    }
}
