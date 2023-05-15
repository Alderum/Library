using Library.View;
using Library.View.Main;
using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Library.AppController
{
    internal class Controller
    {
        FormLog formLog;
        FormMain formMain;
        public Controller() : base()
        {
            formLog = new FormLog(this);
            formMain = new FormMain(this);
            formLog.Show();
        }
        public FormLog FormLog
        {
            get
            {
                return formLog;
            }
        }
        public FormMain FormMain
        {
            get
            {
                return formMain;
            }
        }

        User user = new User();
        Book book = new Book();
        //Login user if 
        public bool UserLogin(string name, string password)
        {
            try
            {
                user.Initialise(name, password);
                return true;
            }
            catch (DuplicateValueException ex)
            {
                //The user isn't registrated
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void RegisterUser(Form parentForm, string name, string password, string email)
        {
            try
            {
                user.Initialise(name, password, email);
                user.Add();
            }
            catch (DuplicateValueException ex)
            {
                //The user has been registrated yet
                MessageBox.Show(ex.Message);
                parentForm.Hide();
                FormLogin formLogin = new FormLogin(formLog);
                formLogin.ShowDialog();
                parentForm.Close();
            }
        }

        public void UserUpdate(string parametr, string value)
        {
            user.Update(parametr, value);
        }
        //User must be logined
        public (int id, string name, string password, string image, string email, string aby, string abyrb, string userString)  UserGet()
        {
            return user.Get(User.Name, User.Password);
        }

        public void UserDelete()
        {
            user.Delete();
        }
        //Places the form in the panel
        public void OpenChildForm(Form childForm, Panel panel)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panel.Controls.Add(childForm);
            panel.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        public IEnumerable<Book> GetNecessaryBooksList(string title, string author)
        {
            //Return list of books depending on title and author
            if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(author))
                return from b in book.GetAllBooksList() where book.Author == author && book.Title == title select b;
            else if (!string.IsNullOrEmpty(title))
                return from b in book.GetAllBooksList() where book.Title == title select b;
            else if (!string.IsNullOrEmpty(author))
                return from b in book.GetAllBooksList() where book.Author == author select b;
            else
                return book.GetAllBooksList();
        }

        public void ShowForm(Form form)
        {
            form.Show();
        }
    }
}
