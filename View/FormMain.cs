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

namespace Library.View.Main
{
    internal partial class FormMain : Form
    {
        public Controller controller;
        Form1 form1;
        public FormMain(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
            form1 = new Form1(controller);
            Size = form1.size;
            controller.OpenChildForm(form1, mainPanel);
        }

        public Panel PanelMain { get { return mainPanel; } }
    }
}
