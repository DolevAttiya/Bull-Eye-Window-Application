namespace Bull_Eye.WindowUI
{
    partial class FormGame
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
            this.buttonComputerGuess1 = new System.Windows.Forms.Button();
            this.buttonComputerGuess2 = new System.Windows.Forms.Button();
            this.buttonComputerGuess3 = new System.Windows.Forms.Button();
            this.buttonComputerGuess4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonComputerGuess1
            // 
            this.buttonComputerGuess1.BackColor = System.Drawing.Color.Black;
            this.buttonComputerGuess1.Enabled = false;
            this.buttonComputerGuess1.Location = new System.Drawing.Point(20, 8);
            this.buttonComputerGuess1.Name = "buttonComputerGuess1";
            this.buttonComputerGuess1.Size = new System.Drawing.Size(43, 43);
            this.buttonComputerGuess1.TabIndex = 0;
            this.buttonComputerGuess1.UseVisualStyleBackColor = false;
            // 
            // buttonComputerGuess2
            // 
            this.buttonComputerGuess2.BackColor = System.Drawing.Color.Black;
            this.buttonComputerGuess2.Enabled = false;
            this.buttonComputerGuess2.Location = new System.Drawing.Point(69, 8);
            this.buttonComputerGuess2.Name = "buttonComputerGuess2";
            this.buttonComputerGuess2.Size = new System.Drawing.Size(43, 43);
            this.buttonComputerGuess2.TabIndex = 1;
            this.buttonComputerGuess2.UseVisualStyleBackColor = false;
            // 
            // buttonComputerGuess3
            // 
            this.buttonComputerGuess3.BackColor = System.Drawing.Color.Black;
            this.buttonComputerGuess3.Enabled = false;
            this.buttonComputerGuess3.Location = new System.Drawing.Point(118, 8);
            this.buttonComputerGuess3.Name = "buttonComputerGuess3";
            this.buttonComputerGuess3.Size = new System.Drawing.Size(43, 43);
            this.buttonComputerGuess3.TabIndex = 2;
            this.buttonComputerGuess3.UseVisualStyleBackColor = false;
            // 
            // buttonComputerGuess4
            // 
            this.buttonComputerGuess4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonComputerGuess4.BackColor = System.Drawing.Color.Black;
            this.buttonComputerGuess4.Enabled = false;
            this.buttonComputerGuess4.Location = new System.Drawing.Point(167, 8);
            this.buttonComputerGuess4.Name = "buttonComputerGuess4";
            this.buttonComputerGuess4.Size = new System.Drawing.Size(43, 43);
            this.buttonComputerGuess4.TabIndex = 3;
            this.buttonComputerGuess4.UseVisualStyleBackColor = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 426);
            this.Controls.Add(this.buttonComputerGuess4);
            this.Controls.Add(this.buttonComputerGuess3);
            this.Controls.Add(this.buttonComputerGuess2);
            this.Controls.Add(this.buttonComputerGuess1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGame";
            this.Text = "Bool Pgia";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonComputerGuess1;
        private System.Windows.Forms.Button buttonComputerGuess2;
        private System.Windows.Forms.Button buttonComputerGuess3;
        private System.Windows.Forms.Button buttonComputerGuess4;
    }
}