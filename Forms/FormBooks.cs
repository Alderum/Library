using iTextSharp.text.factories;
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
        string imagePath, textPath;

        //Changea the visable of a buttonDelete
        public bool butDelVis
        {
            get { return buttonDelete.Visible; }
            set { buttonDelete.Visible = value; }
        }
        public FormBooks()
        {
            InitializeComponent();
            buttonDelete.Visible = butDelVis;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = "c:\\";

            if (!string.IsNullOrEmpty(bookNameText.Text) || !string.IsNullOrEmpty(bookAuthorText.Text) || !string.IsNullOrEmpty(imagePath) || !string.IsNullOrEmpty(textPath))
            {
                Book book = new Book(bookNameText.Text, bookAuthorText.Text, imagePath, textPath);
                book.Add();
            }
            else
            {
                MessageBox.Show("Enter all books fields (pick an image).");
            }
        }
        public void OpenChildForm(BookViewer childForm)
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
            string title, author;

            var fc = Application.OpenForms.Cast<Form>().ToList();
            foreach(Form form in fc)
            {
                if(form != null && form.Name == "BookViewer")
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

            Database database = new Database(this);
            if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(author))
                database.View(title, author);
            else if (!string.IsNullOrEmpty(title))
                database.ViewWithParametr("title", title);
            else if (!string.IsNullOrEmpty(author))
                database.ViewWithParametr("author", author);
            else
                database.View();
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
    }
}
