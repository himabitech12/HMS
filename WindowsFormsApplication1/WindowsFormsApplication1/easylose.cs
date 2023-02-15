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
    public partial class easylose : Form
    {
        public easylose()
        {
            InitializeComponent();
        }

        private void playagainbtn_Click(object sender, EventArgs e)
        {
            dashbaord.instance.pnl.Controls.Clear();
            easyboard e_board = new easyboard() { TopLevel = false, TopMost = true };
            dashbaord.instance.pnl.Controls.Add(e_board);
            e_board.Show();
            e_board.Dock = DockStyle.Fill;
            this.Close();
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            dashbaord.instance.pnl.Controls.Clear();
            mainmenu m_menu = new mainmenu() { TopLevel = false, TopMost = true };
            dashbaord.instance.pnl.Controls.Add(m_menu);
            m_menu.Show();
            m_menu.Dock = DockStyle.Fill;
            this.Close();
        }
    }
}
