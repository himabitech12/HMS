namespace WindowsFormsApplication1
{
    partial class mainmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainmenu));
            this.playbtn = new System.Windows.Forms.Button();
            this.recordbtn = new System.Windows.Forms.Button();
            this.helpbtn = new System.Windows.Forms.Button();
            this.music_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playbtn
            // 
            this.playbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.playbtn.BackColor = System.Drawing.Color.YellowGreen;
            this.playbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playbtn.Location = new System.Drawing.Point(242, 111);
            this.playbtn.Name = "playbtn";
            this.playbtn.Size = new System.Drawing.Size(170, 59);
            this.playbtn.TabIndex = 0;
            this.playbtn.Text = "Play";
            this.playbtn.UseVisualStyleBackColor = false;
            this.playbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // recordbtn
            // 
            this.recordbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.recordbtn.BackColor = System.Drawing.Color.YellowGreen;
            this.recordbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recordbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordbtn.Location = new System.Drawing.Point(242, 190);
            this.recordbtn.Name = "recordbtn";
            this.recordbtn.Size = new System.Drawing.Size(170, 59);
            this.recordbtn.TabIndex = 6;
            this.recordbtn.Text = "Records";
            this.recordbtn.UseVisualStyleBackColor = false;
            this.recordbtn.Click += new System.EventHandler(this.recordbtn_Click);
            // 
            // helpbtn
            // 
            this.helpbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.helpbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.helpbtn.BackColor = System.Drawing.Color.YellowGreen;
            this.helpbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpbtn.Location = new System.Drawing.Point(242, 275);
            this.helpbtn.Name = "helpbtn";
            this.helpbtn.Size = new System.Drawing.Size(170, 59);
            this.helpbtn.TabIndex = 7;
            this.helpbtn.Text = "Help";
            this.helpbtn.UseVisualStyleBackColor = false;
            this.helpbtn.Click += new System.EventHandler(this.helpbtn_Click);
            // 
            // music_btn
            // 
            this.music_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.music_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.music_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("music_btn.BackgroundImage")));
            this.music_btn.Location = new System.Drawing.Point(567, 22);
            this.music_btn.Name = "music_btn";
            this.music_btn.Size = new System.Drawing.Size(50, 50);
            this.music_btn.TabIndex = 8;
            this.music_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.music_btn.UseVisualStyleBackColor = true;
            this.music_btn.Click += new System.EventHandler(this.music_btn_Click);
            // 
            // mainmenu
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(638, 411);
            this.Controls.Add(this.music_btn);
            this.Controls.Add(this.helpbtn);
            this.Controls.Add(this.recordbtn);
            this.Controls.Add(this.playbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "mainmenu";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playbtn;
        private System.Windows.Forms.Button recordbtn;
        private System.Windows.Forms.Button helpbtn;
        private System.Windows.Forms.Button music_btn;
    }
}