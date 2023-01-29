namespace Library
{
    partial class BookViewer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bookPicture = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelBookName = new System.Windows.Forms.Label();
            this.labelBookAuthor = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTextPath = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookPicture)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bookPicture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 126);
            this.panel1.TabIndex = 0;
            // 
            // bookPicture
            // 
            this.bookPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookPicture.Location = new System.Drawing.Point(12, 12);
            this.bookPicture.Name = "bookPicture";
            this.bookPicture.Size = new System.Drawing.Size(113, 102);
            this.bookPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bookPicture.TabIndex = 0;
            this.bookPicture.TabStop = false;
            this.bookPicture.Click += new System.EventHandler(this.bookPicture_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelBookName);
            this.panel2.Controls.Add(this.labelBookAuthor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(139, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 126);
            this.panel2.TabIndex = 1;
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.labelBookName.Location = new System.Drawing.Point(6, 12);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(51, 20);
            this.labelBookName.TabIndex = 2;
            this.labelBookName.Text = "Name";
            // 
            // labelBookAuthor
            // 
            this.labelBookAuthor.AutoSize = true;
            this.labelBookAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBookAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.labelBookAuthor.Location = new System.Drawing.Point(6, 51);
            this.labelBookAuthor.Name = "labelBookAuthor";
            this.labelBookAuthor.Size = new System.Drawing.Size(76, 20);
            this.labelBookAuthor.TabIndex = 0;
            this.labelBookAuthor.Text = "A. Author";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelTextPath);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(280, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 126);
            this.panel3.TabIndex = 2;
            // 
            // labelTextPath
            // 
            this.labelTextPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTextPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.labelTextPath.Location = new System.Drawing.Point(62, 0);
            this.labelTextPath.Name = "labelTextPath";
            this.labelTextPath.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.labelTextPath.Size = new System.Drawing.Size(458, 126);
            this.labelTextPath.TabIndex = 1;
            this.labelTextPath.Text = "Text path";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.label3.Size = new System.Drawing.Size(62, 126);
            this.label3.TabIndex = 0;
            this.label3.Text = "Text:";
            // 
            // BookViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(800, 126);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookViewer";
            this.Text = "Book";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookPicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox bookPicture;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelBookAuthor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Label labelTextPath;
    }
}