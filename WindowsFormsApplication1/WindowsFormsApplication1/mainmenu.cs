using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class mainmenu : Form
    {
        SoundPlayer splay = new SoundPlayer(@"C:\Users\admin\Desktop\WindowsFormsApplication1\WindowsFormsApplication1\game_music.wav");
        
        int m = 0;
        public mainmenu instance;
        public mainmenu()
        {
            InitializeComponent();
            if (m == 0) { splay.Play(); }
            instance = this;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashbaord.instance.pnl.Controls.Clear();
            selection sel  = new selection() { TopLevel = false, TopMost = true };
            dashbaord.instance.pnl.Controls.Add(sel);
            sel.Show();
            sel.Dock = DockStyle.Fill;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
           
        }

        private void recordbtn_Click(object sender, EventArgs e)
        {

          
        }

        private void music_btn_Click(object sender, EventArgs e)
        {
            m++;
            if (m%2==1)
            {
                splay.Stop();
                Image img1 = Image.FromFile(@"C:\Users\admin\Desktop\WindowsFormsApplication1\WindowsFormsApplication1\music_off.jpg");
                this.music_btn.BackgroundImage = img1;
            }
            else if (m % 2 == 0) {
                splay.Play();
                Image img1 = Image.FromFile(@"C:\Users\admin\Desktop\WindowsFormsApplication1\WindowsFormsApplication1\music_on.jpg");
                this.music_btn.BackgroundImage = img1;
            }

        }

        private void helpbtn_Click(object sender, EventArgs e)
        {
            help hp = new help();
            Hide();
            hp.ShowDialog();
            Close();
        }

    }
}
