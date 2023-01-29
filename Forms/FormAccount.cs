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
        public FormAccount(ref User user)
        {
            InitializeComponent();
            this.user = user;
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
            pictureProfile.Load(openFileDialog.FileName);
            
            user.Update("image", openFileDialog.FileName);
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
    }
}