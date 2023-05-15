using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Forms
{
    partial class FormReader : Form
    {
        public delegate void ParentFormStatus();
        public event ParentFormStatus OpenParentForm;
        public FormReader(Book book)
        {
            InitializeComponent();
            Text = string.Format(book.Title, " ", book.Author);
            var doc = PdfiumViewer.PdfDocument.Load(book.TextPath);
            pdfViewer.Document = doc;
        }

        private void FormReader_FormClosing(object sender, FormClosingEventArgs e)
        {
            OpenParentForm();
        }
    }
}
