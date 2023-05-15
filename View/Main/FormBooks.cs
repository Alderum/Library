using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Library.AppController;
using Library.Forms;
using System.Linq;

namespace Library
{
    partial class FormBooks : Form
    {
        Controller controller;
        Book book;
        string imagePath, textPath;
        
        public FormBooks(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
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

            //Event from FormReader (invokes method Show)
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
            //Removing all book forms
            var fc = Application.OpenForms.Cast<Form>().ToList();
            foreach (Form form in fc)
            {
                if (form != null && form.Name == "BookViewer")
                {
                    form.Close();
                }
            }
            //Removing all book panels
            foreach (Control item in flp.Controls.OfType<Control>().ToList())
            {
                if (item != null && item.Name == "PanelForm")
                    item.Dispose();
            }

            title = textTitleSearch.Text;
            author = textAuthorSearch.Text;

            ViewBooksList(controller.GetNecessaryBooksList(title, author));
        }

        private void textTitleSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                textAuthorSearch.Focus();
            }
        }

        private void ViewBooksList(IEnumerable<Book> booksList)
        {
            foreach (Book book in booksList)
            {
                BookViewer bookViewer = new BookViewer(book);
                bookViewer.SetButtonVisible += ButtonVisible;

                //Creating a panel to place book form in
                Panel panel = new Panel()
                {
                    BackColor = Color.White,
                    Size = new Size(flp.Width, 130),
                    Name = "PanelForm"
                };
                flp.Controls.Add(panel);
                //Place book form in
                controller.OpenChildForm(bookViewer, panel);
            }
        }
    }
}
