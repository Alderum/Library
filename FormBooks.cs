using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class FormBooks : Form
    {
        //Create an object of Database class for work with Mikrosoft Access database
        Database database = new Database();

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
            //Opens books form
            OpenChildForm(new Book(this));
        }

        private void OpenChildForm(Book childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Top;
            
            //Set value for book
            childForm.BookName = bookNameText.Text;
            childForm.BookAuthor = bookAuthorText.Text;

            //Set data
            //database.AddBook(bookNameText.Text, bookAuthorText.Text);

            panelBooks.Controls.Add(childForm);
            panelBooks.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }
    }
}
