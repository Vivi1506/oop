using System;
using System.Collections.Generic;
using System.Text;

namespace lab2_3
{
    class Book
    {
        private Content __content;
        private Title __title;
        private Author __author;
        public Book(string content, string title,string author)
        {
            __content = new Content(content);
            __title = new Title(title);
            __author = new Author(author);
        }
        public void Show()
        {
            __author.Show();
            __content.Show();
            __title.Show();
        }

    }
}
