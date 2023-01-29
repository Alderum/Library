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
        User user = new User();
        public FormRegistrate()
        {
            InitializeComponent();
            pictureBox.Image = Image.FromFile(Database.assetsPath + "\\LeftArrow.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();

            FormLogin formLogin = new FormLogin(ref user);
            formLogin.ShowDialog();

            Close();
        }

        private void buttonRegistrate_Click(object sender, EventArgs e)
        {
            string name = userNameText.Text;
            string password = userPasswordText.Text;
            string e_mail = userE_mailText.Text;

            user.Initialise(name, password, e_mail);
            user.Add();
        }
    }
}
