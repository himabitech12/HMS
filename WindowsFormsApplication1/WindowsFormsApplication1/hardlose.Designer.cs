namespace WindowsFormsApplication1
{
    partial class hardlose
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
            this.menubtn = new System.Windows.Forms.Button();
            this.playagainbtn = new System.Windows.Forms.Button();
            this.label_l = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menubtn
            // 
            this.menubtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menubtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menubtn.FlatAppearance.BorderSize = 3;
            this.menubtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menubtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menubtn.Location = new System.Drawing.Point(79, 188);
            this.menubtn.Name = "menubtn";
            this.menubtn.Size = new System.Drawing.Size(137, 39);
            this.menubtn.TabIndex = 5;
            this.menubtn.Text = "Main Menu";
            this.menubtn.UseVisualStyleBackColor = false;
            this.menubtn.Click += new System.EventHandler(this.menubtn_Click);
            // 
            // playagainbtn
            // 
            this.playagainbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.playagainbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playagainbtn.FlatAppearance.BorderSize = 3;
            this.playagainbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playagainbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playagainbtn.Location = new System.Drawing.Point(79, 132);
            this.playagainbtn.Name = "playagainbtn";
            this.playagainbtn.Size = new System.Drawing.Size(137, 39);
            this.playagainbtn.TabIndex = 4;
            this.playagainbtn.Text = "Play Again";
            this.playagainbtn.UseVisualStyleBackColor = false;
            this.playagainbtn.Click += new System.EventHandler(this.playagainbtn_Click);
            // 
            // label_l
            // 
            this.label_l.AutoSize = true;
            this.label_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_l.Location = new System.Drawing.Point(57, 53);
            this.label_l.Name = "label_l";
            this.label_l.Size = new System.Drawing.Size(192, 39);
            this.label_l.TabIndex = 3;
            this.label_l.Text = "You Lose!!!";
            // 
            // hardlose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menubtn);
            this.Controls.Add(this.playagainbtn);
            this.Controls.Add(this.label_l);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "hardlose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "lose";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menubtn;
        private System.Windows.Forms.Button playagainbtn;
        private System.Windows.Forms.Label label_l;
    }
}