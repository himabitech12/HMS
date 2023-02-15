namespace WindowsFormsApplication1
{
    partial class dashbaord
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
            this.pnl_show = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnl_show
            // 
            this.pnl_show.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_show.Location = new System.Drawing.Point(-5, 1);
            this.pnl_show.Name = "pnl_show";
            this.pnl_show.Size = new System.Drawing.Size(666, 514);
            this.pnl_show.TabIndex = 0;
            // 
            // dashbaord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 516);
            this.Controls.Add(this.pnl_show);
            this.MaximizeBox = false;
            this.Name = "dashbaord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_show;
    }
}