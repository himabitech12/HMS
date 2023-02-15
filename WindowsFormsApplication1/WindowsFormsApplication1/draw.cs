using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class draw : Form
    {

        public draw()
        {
            InitializeComponent();
        }

        private void draw_Load(object sender, EventArgs e)
        {

        }

        private void playagainbtn2_Click(object sender, EventArgs e)
        {
            board bd = new board();
            Hide();
            bd.ShowDialog();
            Close();
        }

        private void menubtn2_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }
    }
}
