using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.AppController;
using Library.View.Main;

namespace Library.View
{
    internal partial class FormLog : Form
    {
        public Controller controller;
        FormLogin formLogin;
        public FormRegistrate formRegistrate;

        public FormLog(Controller controller)
        {
            InitializeComponent();

            this.controller = controller;

            formRegistrate = new FormRegistrate(this);
            formLogin = new FormLogin(this);
            formLogin.OpenRegisterForm += OpenRegisterForm;

            Width = formLogin.size.Width;
            Height = formLogin.size.Height;

            this.controller = controller;
            controller.OpenChildForm(formLogin, panelFormLog);
        }
        private void OpenRegisterForm()
        {
            Width = formRegistrate.size.Width;
            Height = formRegistrate.size.Height;

            formLogin.Hide();
            controller.OpenChildForm(formRegistrate, panelFormLog);
        }

        public void OpenFormLogin()
        {
            Width = formLogin.size.Width;
            Height = formLogin.size.Height;

            formRegistrate.Hide();
            controller.OpenChildForm(formLogin, panelFormLog);
        }
    }
}
