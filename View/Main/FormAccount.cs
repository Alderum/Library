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
using Library.View.Main;

namespace Library
{
    internal partial class FormAccount : Form
    {
        Controller controller;
        public FormAccount(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
            //Set profile datas
            pictureProfile.Load(controller.UserGet().image);
            nameLable.Text = controller.UserGet().name;
            emailLable.Text = controller.UserGet().email;
            abyTextBox.Text = controller.UserGet().aby;
            abyrbTextBox.Text = controller.UserGet().abyrb;
        }

        private void pictureProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "jpg files (*.jpg)|*.jpg";
            openFileDialog.ShowDialog();
            try
            {
                pictureProfile.Load(openFileDialog.FileName);
                controller.UserUpdate("image", openFileDialog.FileName);
                User.Image = openFileDialog.FileName;
            }
            catch(InvalidOperationException ex)
            {
                MessageBox.Show(controller.UserGet().userString);
                pictureProfile.Load(User.Image);
            }
        }

        private void passwordLable_Click(object sender, EventArgs e)
        {
            MessageBox.Show(controller.UserGet().password);
        }

        private void abyTextBox_Leave(object sender, EventArgs e)
        {
            controller.UserUpdate("aby", abyTextBox.Text);
        }

        private void abyrbTextBox_Leave(object sender, EventArgs e)
        {
            controller.UserUpdate("abyrb", abyrbTextBox.Text);
        }

        private void buttonDeleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Accout deleting", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                controller.UserDelete();
                Hide();
                controller.FormMain.Hide();
                FormLogin formLogin = new FormLogin(controller.FormLog);
                formLogin.ShowDialog();
                controller.FormMain.Close();
                Close();
            }
        }
    }
}