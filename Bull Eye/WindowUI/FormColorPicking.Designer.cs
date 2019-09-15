namespace Bull_Eye.WindowUI
{
    partial class FormColorPicking
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
            this.buttonPurple = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonLime = new System.Windows.Forms.Button();
            this.buttonCyan = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.buttonBrown = new System.Windows.Forms.Button();
            this.buttonWhite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPurple
            // 
            this.buttonPurple.BackColor = System.Drawing.Color.Purple;
            this.buttonPurple.Enabled = true;
            this.buttonPurple.Location = new System.Drawing.Point(12, 12);
            this.buttonPurple.Name = "buttonPurple";
            this.buttonPurple.Size = new System.Drawing.Size(43, 43);
            this.buttonPurple.TabIndex = 3;
            this.buttonPurple.UseVisualStyleBackColor = false;
            this.buttonPurple.Click += new System.EventHandler(this.buttonPurple_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Red;
            this.buttonRed.Enabled = true;
            this.buttonRed.Location = new System.Drawing.Point(61, 12);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(43, 43);
            this.buttonRed.TabIndex = 4;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonLime
            // 
            this.buttonLime.BackColor = System.Drawing.Color.Lime;
            this.buttonLime.Enabled = true;
            this.buttonLime.Location = new System.Drawing.Point(110, 12);
            this.buttonLime.Name = "buttonLime";
            this.buttonLime.Size = new System.Drawing.Size(43, 43);
            this.buttonLime.TabIndex = 5;
            this.buttonLime.UseVisualStyleBackColor = false;
            this.buttonLime.Click += new System.EventHandler(this.buttonLime_Click);
            // 
            // buttonCyan
            // 
            this.buttonCyan.BackColor = System.Drawing.Color.Cyan;
            this.buttonLime.Enabled = true;
            this.buttonCyan.Location = new System.Drawing.Point(159, 12);
            this.buttonCyan.Name = "buttonCyan";
            this.buttonCyan.Size = new System.Drawing.Size(43, 43);
            this.buttonCyan.TabIndex = 6;
            this.buttonCyan.UseVisualStyleBackColor = false;
            this.buttonCyan.Click += new System.EventHandler(this.buttonCyan_Click);
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackColor = System.Drawing.Color.Blue;
            this.buttonLime.Enabled = true;
            this.buttonBlue.Location = new System.Drawing.Point(12, 61);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(43, 43);
            this.buttonBlue.TabIndex = 7;
            this.buttonBlue.UseVisualStyleBackColor = false;
            this.buttonBlue.Click += new System.EventHandler(this.buttonBlue_Click);
            // 
            // buttonYellow
            // 
            this.buttonYellow.BackColor = System.Drawing.Color.Yellow;
            this.buttonLime.Enabled = true;
            this.buttonYellow.Location = new System.Drawing.Point(61, 61);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(43, 43);
            this.buttonYellow.TabIndex = 8;
            this.buttonYellow.UseVisualStyleBackColor = false;
            this.buttonYellow.Click += new System.EventHandler(this.buttonYellow_Click);
            // 
            // buttonBrown
            // 
            this.buttonBrown.BackColor = System.Drawing.Color.Brown;
            this.buttonLime.Enabled = true;
            this.buttonBrown.Location = new System.Drawing.Point(110, 61);
            this.buttonBrown.Name = "buttonBrown";
            this.buttonBrown.Size = new System.Drawing.Size(43, 43);
            this.buttonBrown.TabIndex = 9;
            this.buttonBrown.UseVisualStyleBackColor = false;
            this.buttonBrown.Click += new System.EventHandler(this.buttonBrown_Click);
            // 
            // buttonWhite
            // 
            this.buttonWhite.BackColor = System.Drawing.Color.White;
            this.buttonLime.Enabled = true;
            this.buttonWhite.Location = new System.Drawing.Point(159, 61);
            this.buttonWhite.Name = "buttonWhite";
            this.buttonWhite.Size = new System.Drawing.Size(43, 43);
            this.buttonWhite.TabIndex = 10;
            this.buttonWhite.UseVisualStyleBackColor = false;
            this.buttonWhite.Click += new System.EventHandler(this.buttonWhite_Click);
            // 
            // FormColorPicking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 113);
            this.Controls.Add(this.buttonWhite);
            this.Controls.Add(this.buttonBrown);
            this.Controls.Add(this.buttonYellow);
            this.Controls.Add(this.buttonBlue);
            this.Controls.Add(this.buttonCyan);
            this.Controls.Add(this.buttonLime);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.buttonPurple);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormColorPicking";
            this.Text = "Pick A Color:";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPurple;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonLime;
        private System.Windows.Forms.Button buttonCyan;
        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Button buttonYellow;
        private System.Windows.Forms.Button buttonBrown;
        private System.Windows.Forms.Button buttonWhite;
    }
}