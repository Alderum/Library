namespace Library
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.userPasswordText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.BackColor = System.Drawing.Color.Transparent;
            this.buttonRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistration.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.buttonRegistration.Location = new System.Drawing.Point(47, 474);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(500, 40);
            this.buttonRegistration.TabIndex = 17;
            this.buttonRegistration.Text = "Registration";
            this.buttonRegistration.UseVisualStyleBackColor = false;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.Black;
            this.buttonLogin.Location = new System.Drawing.Point(46, 367);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(500, 90);
            this.buttonLogin.TabIndex = 16;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // userPasswordText
            // 
            this.userPasswordText.BackColor = System.Drawing.Color.White;
            this.userPasswordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userPasswordText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userPasswordText.Location = new System.Drawing.Point(28, 290);
            this.userPasswordText.Name = "userPasswordText";
            this.userPasswordText.Size = new System.Drawing.Size(540, 62);
            this.userPasswordText.TabIndex = 15;
            this.userPasswordText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userPasswordText_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(34, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "Password:";
            // 
            // userNameText
            // 
            this.userNameText.BackColor = System.Drawing.Color.White;
            this.userNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userNameText.Location = new System.Drawing.Point(30, 166);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(540, 62);
            this.userNameText.TabIndex = 13;
            this.userNameText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userNameText_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(34, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "User name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 86);
            this.label3.TabIndex = 18;
            this.label3.Text = "Login";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(598, 530);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.userPasswordText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userNameText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.Text = "Library LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox userPasswordText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}