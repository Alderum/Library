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
    public partial class FormRegistrate : Form
    {
        Database database = new Database();
        public FormRegistrate()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();

            this.Close();
        }

        private void buttonRegistrate_Click(object sender, EventArgs e)
        {
            string name = userNameText.Text;
            string password = userPasswordText.Text;
            string e_mail = userE_mailText.Text;
            database.AddUser(name, password, e_mail);
        }
    }
}
