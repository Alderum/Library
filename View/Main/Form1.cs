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
    internal partial class Form1 : Form
    {
        Controller controller;
        public Size size;
        public Form1(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
            panelLogo.BackgroundImage = Image.FromFile(Database.assetsPath + "\\Logo.jpg");
            size = new Size(Width, Height);
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            controller.OpenChildForm(new FormAccount(controller), controller.FormMain.PanelMain);
        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            controller.OpenChildForm(new FormBooks(controller), panelMain);
        }
    }
}
