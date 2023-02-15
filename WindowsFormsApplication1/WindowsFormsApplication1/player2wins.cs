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
    public partial class player2wins : Form
    {
        board bd=new board();
        mainmenu mm = new mainmenu();
        public player2wins()
        {
            InitializeComponent();
        }

        private void player2wins_Load(object sender, EventArgs e)
        {

        }

        private void playagainbtn1_Click(object sender, EventArgs e)
        {
            dashbaord.instance.pnl.Controls.Clear();
            easyboard e_board = new easyboard() { TopLevel = false, TopMost = true };
            dashbaord.instance.pnl.Controls.Add(e_board);
            e_board.Show();
            e_board.Dock = DockStyle.Fill;
            this.Close();
        }

        private void menubtn1_Click(object sender, EventArgs e)
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
