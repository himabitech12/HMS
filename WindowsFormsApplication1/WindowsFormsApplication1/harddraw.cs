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
    public partial class harddraw : Form
    {
        public harddraw()
        {
            InitializeComponent();
        }

        private void playagainbtn_Click(object sender, EventArgs e)
        {
            hardboard hb = new hardboard();
            Hide();
            hb.ShowDialog();
            Close();
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
