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
using Library.View;

namespace Library
{
    internal partial class FormRegistrate : Form
    {
        FormLog formLog;
        public Size size;

        public FormRegistrate(FormLog formLog)
        {
            InitializeComponent();
            this.formLog = formLog;
            size = new Size(Width, Height);
            pictureBox.Image = Image.FromFile(Database.assetsPath + "\\LeftArrow.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            formLog.OpenFormLogin();
        }

        private void buttonRegistrate_Click(object sender, EventArgs e)
        {
            string name = userNameText.Text;
            string password = userPasswordText.Text;
            string email = userE_mailText.Text;

            formLog.controller.RegisterUser(this, name, password, email);
        }
    }
}
