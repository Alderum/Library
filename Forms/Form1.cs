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
    internal partial class Form1 : Form
    {
        User user;
        public Form1(ref User user)
        {
            InitializeComponent();
            panelLogo.BackgroundImage = Image.FromFile(Database.assetsPath + "\\Logo.jpg");
            this.user = user;
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAccount(ref user));
        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBooks());
        }

        Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }
    }
}
