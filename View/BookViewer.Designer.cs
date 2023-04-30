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
            this.bookPicture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelBookAuthor = new System.Windows.Forms.Label();
            this.labelBookName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelTextPath = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bookPicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookPicture
            // 
            this.bookPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookPicture.Location = new System.Drawing.Point(12, 12);
            this.bookPicture.Name = "bookPicture";
            this.bookPicture.Size = new System.Drawing.Size(120, 168);
            this.bookPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bookPicture.TabIndex = 0;
            this.bookPicture.TabStop = false;
            this.bookPicture.Click += new System.EventHandler(this.bookPicture_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.bookPicture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 198);
            this.panel1.TabIndex = 0;
            // 
            // labelBookAuthor
            // 
            this.labelBookAuthor.BackColor = System.Drawing.Color.White;
            this.labelBookAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBookAuthor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelBookAuthor.Location = new System.Drawing.Point(0, 100);
            this.labelBookAuthor.Name = "labelBookAuthor";
            this.labelBookAuthor.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.labelBookAuthor.Size = new System.Drawing.Size(201, 98);
            this.labelBookAuthor.TabIndex = 0;
            this.labelBookAuthor.Text = "A. Author";
            // 
            // labelBookName
            // 
            this.labelBookName.BackColor = System.Drawing.Color.White;
            this.labelBookName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBookName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookName.ForeColor = System.Drawing.Color.Black;
            this.labelBookName.Location = new System.Drawing.Point(0, 0);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.labelBookName.Size = new System.Drawing.Size(201, 100);
            this.labelBookName.TabIndex = 2;
            this.labelBookName.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelBookAuthor);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(144, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 198);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelBookName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(201, 100);
            this.panel4.TabIndex = 3;
            // 
            // labelTextPath
            // 
            this.labelTextPath.BackColor = System.Drawing.Color.White;
            this.labelTextPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTextPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTextPath.ForeColor = System.Drawing.Color.Black;
            this.labelTextPath.Location = new System.Drawing.Point(0, 0);
            this.labelTextPath.Name = "labelTextPath";
            this.labelTextPath.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.labelTextPath.Size = new System.Drawing.Size(485, 198);
            this.labelTextPath.TabIndex = 1;
            this.labelTextPath.Text = "Text path";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelTextPath);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(345, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(485, 198);
            this.panel3.TabIndex = 2;
            // 
            // BookViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(830, 198);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookViewer";
            this.Text = "Book";
            ((System.ComponentModel.ISupportInitialize)(this.bookPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bookPicture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelBookAuthor;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTextPath;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}