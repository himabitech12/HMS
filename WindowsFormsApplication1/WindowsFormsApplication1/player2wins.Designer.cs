namespace WindowsFormsApplication1
{
    partial class player2wins
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
            this.menubtn1 = new System.Windows.Forms.Button();
            this.playagainbtn1 = new System.Windows.Forms.Button();
            this.labelO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menubtn1
            // 
            this.menubtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menubtn1.FlatAppearance.BorderSize = 3;
            this.menubtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menubtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menubtn1.Location = new System.Drawing.Point(79, 164);
            this.menubtn1.Name = "menubtn1";
            this.menubtn1.Size = new System.Drawing.Size(137, 39);
            this.menubtn1.TabIndex = 5;
            this.menubtn1.Text = "Main Menu";
            this.menubtn1.UseVisualStyleBackColor = false;
            this.menubtn1.Click += new System.EventHandler(this.menubtn1_Click);
            // 
            // playagainbtn1
            // 
            this.playagainbtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.playagainbtn1.FlatAppearance.BorderSize = 3;
            this.playagainbtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playagainbtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playagainbtn1.Location = new System.Drawing.Point(79, 103);
            this.playagainbtn1.Name = "playagainbtn1";
            this.playagainbtn1.Size = new System.Drawing.Size(137, 39);
            this.playagainbtn1.TabIndex = 4;
            this.playagainbtn1.Text = "Play Again";
            this.playagainbtn1.UseVisualStyleBackColor = false;
            this.playagainbtn1.Click += new System.EventHandler(this.playagainbtn1_Click);
            // 
            // labelO
            // 
            this.labelO.AutoSize = true;
            this.labelO.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelO.Location = new System.Drawing.Point(12, 9);
            this.labelO.Name = "labelO";
            this.labelO.Size = new System.Drawing.Size(254, 39);
            this.labelO.TabIndex = 3;
            this.labelO.Text = "Player \'O\' WIns";
            // 
            // player2wins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menubtn1);
            this.Controls.Add(this.playagainbtn1);
            this.Controls.Add(this.labelO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "player2wins";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "player2wins";
            this.Load += new System.EventHandler(this.player2wins_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menubtn1;
        private System.Windows.Forms.Button playagainbtn1;
        private System.Windows.Forms.Label labelO;
    }
}