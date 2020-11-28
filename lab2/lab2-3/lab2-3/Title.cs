using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_3
{
    class Title
    {
        public string title { get; private set; }
        public Title(string tit)
        {
            title = tit;
        }
        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(title);

        }
    }
}
