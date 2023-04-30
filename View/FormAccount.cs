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
    internal partial class FormAccount : Form
    {
        User user;
        Form1 mainForm;
        public FormAccount(User user, Form1 form1)
        {
            InitializeComponent();
            this.user = user;
            mainForm = form1;
            //Set profile datas
            pictureProfile.Load(User.Image);
            nameLable.Text = User.Name;
            emailLable.Text = User.Email;
            abyTextBox.Text = User.ABY;
            abyrbTextBox.Text = User.ABYRB;
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
                user.Update("image", openFileDialog.FileName);
                User.Image = openFileDialog.FileName;
            }
            catch(InvalidOperationException ex)
            {
                MessageBox.Show(user.ToString());
                pictureProfile.Load(User.Image);
            }
        }

        private void passwordLable_Click(object sender, EventArgs e)
        {
            MessageBox.Show(User.Password);
        }

        private void abyTextBox_Leave(object sender, EventArgs e)
        {
            User.ABY = abyTextBox.Text;
            user.Update("aby", abyTextBox.Text);
        }

        private void abyrbTextBox_Leave(object sender, EventArgs e)
        {
            User.ABYRB = abyrbTextBox.Text;
            user.Update("abyrb", abyrbTextBox.Text);
        }

        private void buttonDeleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Accout deleting", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                user.Delete();
                Hide();
                mainForm.Hide();
                FormLogin formLogin = new FormLogin();
                formLogin.ShowDialog();
                mainForm.Close();
                Close();
            }
        }
    }
}