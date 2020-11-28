using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_3
{
    class Author
    {
        public string author { get; private set; }
        public Author(string aut)
        {
            author = aut;
        }
        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(author);

        }
    }
}
