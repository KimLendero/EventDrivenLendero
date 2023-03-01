using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenLendero
{
    public class Library
    {
        public Book[] Books { get; set; }
        public string Genre { get; private set; }

        public Library(Book[] books, string genre)
        {
            this.Books = books;
            this.Genre = genre;
        }
    }
}
