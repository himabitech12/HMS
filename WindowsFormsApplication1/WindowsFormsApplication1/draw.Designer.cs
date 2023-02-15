namespace WindowsFormsApplication1
{
    partial class draw
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
            this.menubtn2 = new System.Windows.Forms.Button();
            this.playagainbtn2 = new System.Windows.Forms.Button();
            this.labelD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menubtn2
            // 
            this.menubtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menubtn2.FlatAppearance.BorderSize = 3;
            this.menubtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menubtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menubtn2.Location = new System.Drawing.Point(85, 164);
            this.menubtn2.Name = "menubtn2";
            this.menubtn2.Size = new System.Drawing.Size(137, 39);
            this.menubtn2.TabIndex = 8;
            this.menubtn2.Text = "Main Menu";
            this.menubtn2.UseVisualStyleBackColor = false;
            this.menubtn2.Click += new System.EventHandler(this.menubtn2_Click);
            // 
            // playagainbtn2
            // 
            this.playagainbtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.playagainbtn2.FlatAppearance.BorderSize = 3;
            this.playagainbtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playagainbtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playagainbtn2.Location = new System.Drawing.Point(85, 103);
            this.playagainbtn2.Name = "playagainbtn2";
            this.playagainbtn2.Size = new System.Drawing.Size(137, 39);
            this.playagainbtn2.TabIndex = 7;
            this.playagainbtn2.Text = "Play Again";
            this.playagainbtn2.UseVisualStyleBackColor = false;
            this.playagainbtn2.Click += new System.EventHandler(this.playagainbtn2_Click);
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelD.Location = new System.Drawing.Point(94, 22);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(128, 39);
            this.labelD.TabIndex = 6;
            this.labelD.Text = "Draw...";
            // 
            // draw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menubtn2);
            this.Controls.Add(this.playagainbtn2);
            this.Controls.Add(this.labelD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "draw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "draw";
            this.Load += new System.EventHandler(this.draw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menubtn2;
        private System.Windows.Forms.Button playagainbtn2;
        private System.Windows.Forms.Label labelD;
    }
}