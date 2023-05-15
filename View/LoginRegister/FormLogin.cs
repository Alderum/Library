using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Library.View;

namespace Library
{
    partial class FormLogin : Form
    {
        public delegate void FormEvent();
        public event FormEvent OpenRegisterForm;
        public Size size;

        FormLog formLog;

        public FormLogin(FormLog formLog)
        {
            InitializeComponent();
            size = new Size(Width, Height);

            this.formLog = formLog;
        }

        private void Login()
        {
            string name = userNameText.Text;
            string password = userPasswordText.Text;
            //If user succesfully logined close FormLog and open FormMain else open FormRegistrate
            if (formLog.controller.UserLogin(name, password))
            {
                formLog.Hide();
                formLog.controller.FormMain.ShowDialog();
                formLog.Close();
            }
            else
                OpenRegisterForm();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            OpenRegisterForm();
        }

        private void userNameText_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                userPasswordText.Focus();
            }
        }

        private void userPasswordText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                Login();
            }
        }
    }
}
