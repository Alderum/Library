using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.cs_files
{
    internal class BookComparer : IComparer<Book>
    {
        public int Compare(Book firstBook, Book secondBook)
        {
            return String.Compare(firstBook.Title, secondBook.Title);
        }
    }
}
