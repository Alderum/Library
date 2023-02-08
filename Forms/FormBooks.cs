using iTextSharp.text.factories;
using Library.cs_files;
using Library.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    partial class FormBooks : Form
    {
        Book book;
        string imagePath, textPath;
        
        public FormBooks()
        {
            InitializeComponent();
            SearchBooks();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = "c:\\";

            if (!string.IsNullOrEmpty(bookNameText.Text) || !string.IsNullOrEmpty(bookAuthorText.Text) || !string.IsNullOrEmpty(imagePath) || !string.IsNullOrEmpty(textPath))
            {
                try
                {
                    Book book = new Book(bookNameText.Text, bookAuthorText.Text, imagePath, textPath);
                    book.Add();
                }
                catch(DuplicateValueException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Enter all books fields (pick an image).");
            }
        }
        private void OpenChildForm(BookViewer childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Top;

            Panel panel = new Panel();
            //Panel
            panel.BackColor = Color.FromArgb(48, 48, 52);
            panel.Size = new Size(flp.Width - 30, 130);
            panel.Name = "PanelForm";

            flp.Controls.Add(panel);
            panel.Controls.Add(childForm);
            panel.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchBooks();
        }

        private void bookImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = "c:\\";
            dialog.Filter = "jpg files (*.jpg)|*.jpg";
            dialog.ShowDialog();

            imagePath = dialog.FileName;

            if(!string.IsNullOrEmpty(imagePath))
                bookImage.Load(imagePath);
        }

        private void bookFileText_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = "c:\\";
            dialog.Filter = "pdf files (*.pdf)|*.pdf";
            dialog.ShowDialog();

            textPath = dialog.FileName;
            bookFileText.Text = textPath;
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            book.Delete();
            buttonDelete.Visible = false;
            buttonOpen.Visible = false;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            FormReader formReader = new FormReader(book);
            formReader.Show();
            Hide();

            formReader.OpenParentForm += Show;
            buttonDelete.Visible = false;
            buttonOpen.Visible = false;
        }
        public void ButtonVisible(Book book)
        {
            this.book = book;

            buttonDelete.Visible = true;
            buttonOpen.Visible = true;
        }

        private void SearchBooks()
        {
            string title, author;

            var fc = Application.OpenForms.Cast<Form>().ToList();
            foreach (Form form in fc)
            {
                if (form != null && form.Name == "BookViewer")
                {
                    form.Close();
                }
            }

            foreach (Control item in flp.Controls.OfType<Control>().ToList())
            {
                if (item != null && item.Name == "PanelForm")
                    item.Dispose();
            }

            title = textTitleSearch.Text;
            author = textAuthorSearch.Text;

            Book book = new Book();

            if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(author))
            {
                BookViewer bookViewer = new BookViewer(book);
                bookViewer.SetButtonVisible += ButtonVisible;
                OpenChildForm(bookViewer);
            }
            else if (!string.IsNullOrEmpty(title))
                ViewBooksList(book.GetBooksList("title", title));
            else if (!string.IsNullOrEmpty(author))
                ViewBooksList(book.GetBooksList("author", author));
            else
                ViewBooksList(book.GetBooksList());
        }

        private void ViewBooksList(SortedSet<Book> booksList)
        {
            foreach(Book book in booksList)
            {
                BookViewer bookViewer = new BookViewer(book);
                bookViewer.SetButtonVisible += ButtonVisible;
                OpenChildForm(bookViewer);
            }
        }
    }
}
