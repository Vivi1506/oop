using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_3
{
    class Content
    {
        public string content { get; private set; }
        public Content(string cnt)
        {
            content = cnt;
        }
        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(content);

        }
    }
}
