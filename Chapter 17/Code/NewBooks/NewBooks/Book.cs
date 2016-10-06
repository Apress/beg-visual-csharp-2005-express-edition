using System;
using System.Collections.Generic;
using System.Text;

namespace NewBooks
{
    class Book
    {
        public string BookTitle;
        public string BookURL;

        public Book( string title, string url)
        {
            BookTitle = title;
            BookURL = url;
        }

        public override string ToString()
        {
            return BookTitle;
        }
    }
}
