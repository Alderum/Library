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
    partial class FormLogin : Form
    {
        Database database = new Database();
        User user;

        public FormLogin()
        {
            InitializeComponent();
            user = new User();
        }

        public FormLogin(User user) : this()
        {
            this.user = user;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string name = userNameText.Text;
            string password = userPasswordText.Text;

            try
            {
                Hide();

                user.Initialise(name, password);
                Form1 form1 = new Form1(user);
                form1.ShowDialog();

                Close();
            }catch(DuplicateValueException ex)
            {
                MessageBox.Show(ex.Message);
                FormRegistrate formRegistrate = new FormRegistrate();
                formRegistrate.ShowDialog();
            }
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
