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
    internal partial class Form1 : Form
    {
        Controller controller = new Controller();
        public Form1()
        {
            InitializeComponent();
            panelLogo.BackgroundImage = Image.FromFile(Database.assetsPath + "\\Logo.jpg");
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            controller.OpenChildForm(new FormAccount(this), panelMain);
        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            controller.OpenChildForm(new FormBooks(), panelMain);
        }
    }
}
