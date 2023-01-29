namespace Library.Forms
{
    partial class FormReader
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
            this.labelTitleAuthor = new System.Windows.Forms.Label();
            this.pdfViewer = new PdfiumViewer.PdfViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTitleAuthor);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 39);
            this.panel1.TabIndex = 1;
            // 
            // labelTitleAuthor
            // 
            this.labelTitleAuthor.AutoSize = true;
            this.labelTitleAuthor.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTitleAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.labelTitleAuthor.Location = new System.Drawing.Point(0, 0);
            this.labelTitleAuthor.Name = "labelTitleAuthor";
            this.labelTitleAuthor.Padding = new System.Windows.Forms.Padding(5, 8, 0, 0);
            this.labelTitleAuthor.Size = new System.Drawing.Size(69, 33);
            this.labelTitleAuthor.TabIndex = 1;
            this.labelTitleAuthor.Text = "label1";
            // 
            // pdfViewer
            // 
            this.pdfViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer.Location = new System.Drawing.Point(0, 39);
            this.pdfViewer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pdfViewer.Name = "pdfViewer";
            this.pdfViewer.Size = new System.Drawing.Size(1163, 578);
            this.pdfViewer.TabIndex = 2;
            // 
            // FormReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1163, 617);
            this.Controls.Add(this.pdfViewer);
            this.Controls.Add(this.panel1);
            this.Name = "FormReader";
            this.Text = "FormReader";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitleAuthor;
        private PdfiumViewer.PdfViewer pdfViewer;
    }
}