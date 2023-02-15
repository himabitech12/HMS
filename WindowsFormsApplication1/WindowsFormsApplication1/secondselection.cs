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
    public partial class secondselection : Form
    {
        public secondselection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashbaord.instance.pnl.Controls.Clear();
            easyboard e_board = new easyboard() { TopLevel = false, TopMost = true };
            dashbaord.instance.pnl.Controls.Add(e_board);
            e_board.Show();
            e_board.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dashbaord.instance.pnl.Controls.Clear();
            hardboard h_board = new hardboard() { TopLevel = false, TopMost = true };
            dashbaord.instance.pnl.Controls.Add(h_board);
            h_board.Show();
            h_board.Dock = DockStyle.Fill;
        }
    }
}
