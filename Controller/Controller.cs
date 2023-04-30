using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.AppController
{
    internal class Controller
    {
        User user = new User();
        //Login user if 
        public void UserLogin(Form parentForm, string name, string password)
        {
            try
            {
                user.Initialise(name, password);
                parentForm.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
                parentForm.Close();
            }
            catch (DuplicateValueException ex)
            {
                //The user isn't registrated
                MessageBox.Show(ex.Message);
                parentForm.Hide();
                FormRegistrate formRegistrate = new FormRegistrate();
                formRegistrate.ShowDialog();
                parentForm.Close();
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
                FormLogin formLogin = new FormLogin();
                formLogin.ShowDialog();
                parentForm.Close();
            }
        }

        public void UserUpdate(string parametr, string value)
        {
            user.Update(parametr, value);
        }

        public (int id, string name, string password, string image, string email, string aby, string abyrb, string userString)  UserGet()
        {
            return (user.Get(User.Name, User.Password));
        }

        public void UserDelete()
        {
            user.Delete();
        }

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
    }
}
