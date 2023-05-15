namespace Library
{
    partial class FormRegistrate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrate));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.userPasswordText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userE_mailText = new System.Windows.Forms.TextBox();
            this.buttonRegistrate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox.Location = new System.Drawing.Point(38, 401);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(64, 64);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(47, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "User name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(47, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password:";
            // 
            // userNameText
            // 
            this.userNameText.BackColor = System.Drawing.Color.White;
            this.userNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userNameText.Location = new System.Drawing.Point(22, 121);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(417, 62);
            this.userNameText.TabIndex = 8;
            // 
            // userPasswordText
            // 
            this.userPasswordText.BackColor = System.Drawing.Color.White;
            this.userPasswordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userPasswordText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userPasswordText.Location = new System.Drawing.Point(22, 221);
            this.userPasswordText.Name = "userPasswordText";
            this.userPasswordText.Size = new System.Drawing.Size(417, 62);
            this.userPasswordText.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(47, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "E-mail:";
            // 
            // userE_mailText
            // 
            this.userE_mailText.BackColor = System.Drawing.Color.White;
            this.userE_mailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userE_mailText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userE_mailText.Location = new System.Drawing.Point(22, 325);
            this.userE_mailText.Name = "userE_mailText";
            this.userE_mailText.Size = new System.Drawing.Size(417, 62);
            this.userE_mailText.TabIndex = 11;
            // 
            // buttonRegistrate
            // 
            this.buttonRegistrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(79)))), ((int)(((byte)(0)))));
            this.buttonRegistrate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistrate.FlatAppearance.BorderSize = 0;
            this.buttonRegistrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrate.ForeColor = System.Drawing.Color.Black;
            this.buttonRegistrate.Location = new System.Drawing.Point(108, 401);
            this.buttonRegistrate.Name = "buttonRegistrate";
            this.buttonRegistrate.Size = new System.Drawing.Size(322, 64);
            this.buttonRegistrate.TabIndex = 12;
            this.buttonRegistrate.Text = "Registrate";
            this.buttonRegistrate.UseVisualStyleBackColor = false;
            this.buttonRegistrate.Click += new System.EventHandler(this.buttonRegistrate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 62);
            this.label4.TabIndex = 13;
            this.label4.Text = "Registration";
            // 
            // FormRegistrate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(462, 481);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonRegistrate);
            this.Controls.Add(this.userE_mailText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userPasswordText);
            this.Controls.Add(this.userNameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormRegistrate";
            this.Text = "Library Registrate";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.TextBox userPasswordText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userE_mailText;
        private System.Windows.Forms.Button buttonRegistrate;
        private System.Windows.Forms.Label label4;
    }
}