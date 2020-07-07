namespace Week7_LinkLabel
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
            this.cDriveLinkLabel = new System.Windows.Forms.LinkLabel();
            this.microsoftDocsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.notePadLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cDriveLinkLabel
            // 
            this.cDriveLinkLabel.AutoSize = true;
            this.cDriveLinkLabel.Location = new System.Drawing.Point(0, 24);
            this.cDriveLinkLabel.Name = "cDriveLinkLabel";
            this.cDriveLinkLabel.Size = new System.Drawing.Size(122, 13);
            this.cDriveLinkLabel.TabIndex = 0;
            this.cDriveLinkLabel.TabStop = true;
            this.cDriveLinkLabel.Text = "Click To Browse C Drive";
            this.cDriveLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.cDriveLinkLabel_LinkClicked);
            // 
            // microsoftDocsLinkLabel
            // 
            this.microsoftDocsLinkLabel.AutoSize = true;
            this.microsoftDocsLinkLabel.Location = new System.Drawing.Point(0, 78);
            this.microsoftDocsLinkLabel.Name = "microsoftDocsLinkLabel";
            this.microsoftDocsLinkLabel.Size = new System.Drawing.Size(138, 13);
            this.microsoftDocsLinkLabel.TabIndex = 1;
            this.microsoftDocsLinkLabel.TabStop = true;
            this.microsoftDocsLinkLabel.Text = "Click to Visit Microsoft Docs";
            this.microsoftDocsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.microsoftDocsLinkLabel_LinkClicked);
            // 
            // notePadLinkLabel
            // 
            this.notePadLinkLabel.AutoSize = true;
            this.notePadLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.notePadLinkLabel.Location = new System.Drawing.Point(0, 132);
            this.notePadLinkLabel.Name = "notePadLinkLabel";
            this.notePadLinkLabel.Size = new System.Drawing.Size(115, 13);
            this.notePadLinkLabel.TabIndex = 2;
            this.notePadLinkLabel.TabStop = true;
            this.notePadLinkLabel.Text = "Click to Open Notepad";
            this.notePadLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.notePadLinkLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "LinkLabel Examples";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 154);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notePadLinkLabel);
            this.Controls.Add(this.microsoftDocsLinkLabel);
            this.Controls.Add(this.cDriveLinkLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel cDriveLinkLabel;
        private System.Windows.Forms.LinkLabel microsoftDocsLinkLabel;
        private System.Windows.Forms.LinkLabel notePadLinkLabel;
        private System.Windows.Forms.Label label1;
    }
}

