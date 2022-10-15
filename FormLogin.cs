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
    public partial class FormLogin : Form
    {
        Database database = new Database();
        Form1 form1 = new Form1();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(database.CheckUser(userNameText.Text, userPasswordText.Text))
            {
                this.Hide();
                form1.ShowDialog();
                this.Close();
            }
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();

            FormRegistrate formRegistrate = new FormRegistrate();
            formRegistrate.ShowDialog();

            this.Close();
        }
    }
}
