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
    public partial class FormRegistrate : Form
    {
        Controller controller = new Controller();

        public FormRegistrate()
        {
            InitializeComponent();
            pictureBox.Image = Image.FromFile(Database.assetsPath + "\\LeftArrow.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            Close();
        }

        private void buttonRegistrate_Click(object sender, EventArgs e)
        {
            string name = userNameText.Text;
            string password = userPasswordText.Text;
            string email = userE_mailText.Text;

            controller.RegisterUser(this, name, password, email);
        }
    }
}
