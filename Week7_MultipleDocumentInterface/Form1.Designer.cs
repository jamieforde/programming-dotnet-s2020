namespace Week7_MultipleDocumentInterface
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lavendarFlowersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleFlowersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowFlowersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lavendarFlowersToolStripMenuItem,
            this.purpleFlowersToolStripMenuItem,
            this.yellowFlowersToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // lavendarFlowersToolStripMenuItem
            // 
            this.lavendarFlowersToolStripMenuItem.Name = "lavendarFlowersToolStripMenuItem";
            this.lavendarFlowersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lavendarFlowersToolStripMenuItem.Text = "Lavendar Flowers";
            this.lavendarFlowersToolStripMenuItem.Click += new System.EventHandler(this.lavendarFlowersToolStripMenuItem_Click);
            // 
            // purpleFlowersToolStripMenuItem
            // 
            this.purpleFlowersToolStripMenuItem.Name = "purpleFlowersToolStripMenuItem";
            this.purpleFlowersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.purpleFlowersToolStripMenuItem.Text = "Purple Flowers";
            this.purpleFlowersToolStripMenuItem.Click += new System.EventHandler(this.purpleFlowersToolStripMenuItem_Click);
            // 
            // yellowFlowersToolStripMenuItem
            // 
            this.yellowFlowersToolStripMenuItem.Name = "yellowFlowersToolStripMenuItem";
            this.yellowFlowersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yellowFlowersToolStripMenuItem.Text = "Yellow Flowers";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lavendarFlowersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purpleFlowersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowFlowersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

