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
        public delegate void ButtonVisiable(Book book);
        public event ButtonVisiable SetButtonVisible;
        public BookViewer(Book book)
        {
            InitializeComponent();
            labelBookName.Text = book.Title;
            labelBookAuthor.Text = book.Author;
            bookPicture.Load(book.ImagePath);
            labelTextPath.Text = book.TextPath;
            this.book = book;
        }

        private void bookPicture_Click(object sender, EventArgs e)
        {
            SetButtonVisible(book);
        }
    }
}
