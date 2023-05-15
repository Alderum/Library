namespace Library.View
{
    partial class FormLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLog));
            this.panelFormLog = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelFormLog
            // 
            this.panelFormLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormLog.Location = new System.Drawing.Point(0, 0);
            this.panelFormLog.Name = "panelFormLog";
            this.panelFormLog.Size = new System.Drawing.Size(800, 450);
            this.panelFormLog.TabIndex = 0;
            // 
            // FormLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFormLog);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLog";
            this.Text = "Library";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormLog;
    }
}