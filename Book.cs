using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Book : Form
    {
        FormBooks formBooks;
        public Book(FormBooks formBooks)
        {
            InitializeComponent();

            this.formBooks = formBooks;
        }

        public string BookName
        {
            get { return labelBookName.Text; }
            set { labelBookName.Text = value; }
        }

        public string BookAuthor
        {
            get { return labelBookAuthor.Text; }
            set { labelBookAuthor.Text = value; }
        }

        private void bookPicture_DoubleClick(object sender, EventArgs e)
        {
            formBooks.butDelVis = !formBooks.butDelVis;
        }
    }
}
