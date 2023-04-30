using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.AppController;

namespace Library
{
    partial class FormLogin : Form
    {
        Controller controller = new Controller();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string name = userNameText.Text;
            string password = userPasswordText.Text;

            controller.UserLogin(this, name, password);
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            Hide();
            FormRegistrate formRegistrate = new FormRegistrate();
            formRegistrate.ShowDialog();
            Close();
        }
    }
}
