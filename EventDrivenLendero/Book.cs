using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenLendero
{
    internal class Book
    {
        private int BookID { get; set; }
        public string Title { get; private set; }
        private Author author { get; set; }
        public string PublishDate { get; private set; }

        public Book(int bookID, string title, Author author, string publishDate)
        {
            this.BookID = bookID;
            this.Title = title;
            this.author = author;
            this.PublishDate = publishDate;
        }
    }
}
