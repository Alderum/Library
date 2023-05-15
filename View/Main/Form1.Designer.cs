
namespace Library
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonBooks = new System.Windows.Forms.Button();
            this.buttonAccount = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelWalcome = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.panelButtons);
            this.panelMenu.Controls.Add(this.panelLogo);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.Name = "panelMenu";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonBooks);
            this.panelButtons.Controls.Add(this.buttonAccount);
            resources.ApplyResources(this.panelButtons, "panelButtons");
            this.panelButtons.Name = "panelButtons";
            // 
            // buttonBooks
            // 
            this.buttonBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonBooks, "buttonBooks");
            this.buttonBooks.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonBooks.FlatAppearance.BorderSize = 0;
            this.buttonBooks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonBooks.ForeColor = System.Drawing.Color.Black;
            this.buttonBooks.Name = "buttonBooks";
            this.buttonBooks.UseVisualStyleBackColor = false;
            this.buttonBooks.Click += new System.EventHandler(this.buttonBooks_Click);
            // 
            // buttonAccount
            // 
            this.buttonAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonAccount, "buttonAccount");
            this.buttonAccount.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonAccount.FlatAppearance.BorderSize = 0;
            this.buttonAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.buttonAccount.ForeColor = System.Drawing.Color.Black;
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.UseVisualStyleBackColor = false;
            this.buttonAccount.Click += new System.EventHandler(this.buttonAccount_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            resources.ApplyResources(this.panelLogo, "panelLogo");
            this.panelLogo.Controls.Add(this.labelName);
            this.panelLogo.Name = "panelLogo";
            // 
            // labelName
            // 
            resources.ApplyResources(this.labelName, "labelName");
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Name = "labelName";
            // 
            // labelWalcome
            // 
            resources.ApplyResources(this.labelWalcome, "labelWalcome");
            this.labelWalcome.ForeColor = System.Drawing.Color.Black;
            this.labelWalcome.Name = "labelWalcome";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.labelWalcome);
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.Name = "panelMain";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Name = "label1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Name = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonAccount;
        private System.Windows.Forms.Button buttonBooks;
        private System.Windows.Forms.Label labelWalcome;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label1;
    }
}

