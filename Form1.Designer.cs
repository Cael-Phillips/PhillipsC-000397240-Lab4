namespace Lab4 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.DisplayBox = new System.Windows.Forms.RichTextBox();
            this.Title = new System.Windows.Forms.Label();
            this.titleStrip = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.Load = new System.Windows.Forms.ToolStripMenuItem();
            this.Process = new System.Windows.Forms.ToolStripMenuItem();
            this.Check = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.titleStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisplayBox
            // 
            this.DisplayBox.Location = new System.Drawing.Point(12, 85);
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.ReadOnly = true;
            this.DisplayBox.Size = new System.Drawing.Size(382, 353);
            this.DisplayBox.TabIndex = 0;
            this.DisplayBox.Text = "";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(13, 66);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(0, 13);
            this.Title.TabIndex = 1;
            // 
            // titleStrip
            // 
            this.titleStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Process,
            this.Exit});
            this.titleStrip.Location = new System.Drawing.Point(0, 0);
            this.titleStrip.Name = "titleStrip";
            this.titleStrip.Size = new System.Drawing.Size(406, 24);
            this.titleStrip.TabIndex = 2;
            this.titleStrip.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Load});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(37, 20);
            this.File.Text = "File";
            // 
            // Load
            // 
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(100, 22);
            this.Load.Text = "Load";
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Process
            // 
            this.Process.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Check});
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(59, 20);
            this.Process.Text = "Process";
            // 
            // Check
            // 
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(133, 22);
            this.Check.Text = "Check Tags";
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(38, 20);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.DisplayBox);
            this.Controls.Add(this.titleStrip);
            this.Name = "Form1";
            this.Text = "Form";
            this.titleStrip.ResumeLayout(false);
            this.titleStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox DisplayBox;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.MenuStrip titleStrip;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem Load;
        private System.Windows.Forms.ToolStripMenuItem Process;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem Check;
    }
}

