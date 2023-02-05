using Library.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    partial class BookViewer : Form
    {
        Book book;
        FormBooks formBooks;
        public BookViewer(Book book, FormBooks formBooks)
        {
            InitializeComponent();
            labelBookName.Text = book.Title;
            labelBookAuthor.Text = book.Author;
            bookPicture.Load(book.ImagePath);
            labelTextPath.Text = book.TextPath;
            this.book = book;
            this.formBooks = formBooks;
        }

        private void bookPicture_Click(object sender, EventArgs e)
        {
            formBooks.ButtonVisible(book);
        }
    }
}
