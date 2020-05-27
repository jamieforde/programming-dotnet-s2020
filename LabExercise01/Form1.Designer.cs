namespace LabExercise01
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
            this.firstLabel = new System.Windows.Forms.Label();
            this.secondLabel = new System.Windows.Forms.Label();
            this.subtractLabel = new System.Windows.Forms.Label();
            this.firstTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.secondTextBox = new System.Windows.Forms.TextBox();
            this.subtractButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.flipButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.Location = new System.Drawing.Point(28, 35);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(56, 13);
            this.firstLabel.TabIndex = 0;
            this.firstLabel.Text = "First Value";
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.Location = new System.Drawing.Point(28, 73);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(74, 13);
            this.secondLabel.TabIndex = 1;
            this.secondLabel.Text = "Second Value";
            // 
            // subtractLabel
            // 
            this.subtractLabel.AutoSize = true;
            this.subtractLabel.Location = new System.Drawing.Point(28, 120);
            this.subtractLabel.Name = "subtractLabel";
            this.subtractLabel.Size = new System.Drawing.Size(61, 13);
            this.subtractLabel.TabIndex = 2;
            this.subtractLabel.Text = "Subtraction";
            // 
            // firstTextBox
            // 
            this.firstTextBox.Location = new System.Drawing.Point(244, 35);
            this.firstTextBox.Name = "firstTextBox";
            this.firstTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstTextBox.TabIndex = 3;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(116, 120);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(228, 20);
            this.resultTextBox.TabIndex = 4;
            // 
            // secondTextBox
            // 
            this.secondTextBox.Location = new System.Drawing.Point(244, 73);
            this.secondTextBox.Name = "secondTextBox";
            this.secondTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondTextBox.TabIndex = 5;
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(31, 168);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(131, 40);
            this.subtractButton.TabIndex = 6;
            this.subtractButton.Text = "Subtract Second - First";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(31, 226);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(131, 40);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear Values";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // flipButton
            // 
            this.flipButton.Location = new System.Drawing.Point(213, 168);
            this.flipButton.Name = "flipButton";
            this.flipButton.Size = new System.Drawing.Size(131, 40);
            this.flipButton.TabIndex = 8;
            this.flipButton.Text = "Flip Values";
            this.flipButton.UseVisualStyleBackColor = true;
            this.flipButton.Click += new System.EventHandler(this.flipButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(213, 226);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(131, 40);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 296);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.flipButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.secondTextBox);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.firstTextBox);
            this.Controls.Add(this.subtractLabel);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.firstLabel);
            this.Name = "Form1";
            this.Text = "Lab Exercise 01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.Label subtractLabel;
        private System.Windows.Forms.TextBox firstTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.TextBox secondTextBox;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button flipButton;
        private System.Windows.Forms.Button exitButton;
    }
}

