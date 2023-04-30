
namespace Library
{
    partial class FormAccount
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
            this.nameLable = new System.Windows.Forms.Label();
            this.passwordLable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDeleteAccount = new System.Windows.Forms.Button();
            this.emailLable = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureProfile = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.abyTextBox = new System.Windows.Forms.TextBox();
            this.abyrbTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nameLable.Location = new System.Drawing.Point(41, 179);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(85, 25);
            this.nameLable.TabIndex = 2;
            this.nameLable.Text = "Alderum";
            // 
            // passwordLable
            // 
            this.passwordLable.AutoSize = true;
            this.passwordLable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.passwordLable.Location = new System.Drawing.Point(34, 218);
            this.passwordLable.Name = "passwordLable";
            this.passwordLable.Size = new System.Drawing.Size(98, 25);
            this.passwordLable.TabIndex = 3;
            this.passwordLable.Text = "Password";
            this.passwordLable.Click += new System.EventHandler(this.passwordLable_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDeleteAccount);
            this.panel1.Controls.Add(this.emailLable);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.passwordLable);
            this.panel1.Controls.Add(this.nameLable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 511);
            this.panel1.TabIndex = 4;
            // 
            // buttonDeleteAccount
            // 
            this.buttonDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.buttonDeleteAccount.Location = new System.Drawing.Point(9, 336);
            this.buttonDeleteAccount.Name = "buttonDeleteAccount";
            this.buttonDeleteAccount.Size = new System.Drawing.Size(142, 37);
            this.buttonDeleteAccount.TabIndex = 11;
            this.buttonDeleteAccount.Text = "Delete Account";
            this.buttonDeleteAccount.UseVisualStyleBackColor = true;
            this.buttonDeleteAccount.Click += new System.EventHandler(this.buttonDeleteAccount_Click);
            // 
            // emailLable
            // 
            this.emailLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.emailLable.Location = new System.Drawing.Point(24, 255);
            this.emailLable.Name = "emailLable";
            this.emailLable.Size = new System.Drawing.Size(130, 78);
            this.emailLable.TabIndex = 5;
            this.emailLable.Text = "E-mail";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureProfile);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 173);
            this.panel2.TabIndex = 4;
            // 
            // pictureProfile
            // 
            this.pictureProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureProfile.Location = new System.Drawing.Point(9, 13);
            this.pictureProfile.Name = "pictureProfile";
            this.pictureProfile.Size = new System.Drawing.Size(150, 150);
            this.pictureProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureProfile.TabIndex = 0;
            this.pictureProfile.TabStop = false;
            this.pictureProfile.Click += new System.EventHandler(this.pictureProfile_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.abyTextBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(168, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(754, 173);
            this.panel3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(1, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "About you:";
            // 
            // abyTextBox
            // 
            this.abyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.abyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.abyTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.abyTextBox.Location = new System.Drawing.Point(87, 12);
            this.abyTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.abyTextBox.Multiline = true;
            this.abyTextBox.Name = "abyTextBox";
            this.abyTextBox.Size = new System.Drawing.Size(655, 145);
            this.abyTextBox.TabIndex = 0;
            this.abyTextBox.Leave += new System.EventHandler(this.abyTextBox_Leave);
            // 
            // abyrbTextBox
            // 
            this.abyrbTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.abyrbTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.abyrbTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.abyrbTextBox.Location = new System.Drawing.Point(178, 201);
            this.abyrbTextBox.Multiline = true;
            this.abyrbTextBox.Name = "abyrbTextBox";
            this.abyrbTextBox.Size = new System.Drawing.Size(732, 290);
            this.abyrbTextBox.TabIndex = 6;
            this.abyrbTextBox.Leave += new System.EventHandler(this.abyrbTextBox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(183, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "About your books:";
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(922, 511);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.abyrbTextBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAccount";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureProfile)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.Label passwordLable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox abyTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label emailLable;
        private System.Windows.Forms.TextBox abyrbTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureProfile;
        private System.Windows.Forms.Button buttonDeleteAccount;
    }
}