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
    public partial class selection : Form
    {
        public selection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            dashbaord.instance.pnl.Controls.Clear();
            board bd = new board() { TopLevel = false, TopMost = true };
            dashbaord.instance.pnl.Controls.Add(bd);
            bd.Show();
            bd.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dashbaord.instance.pnl.Controls.Clear();
            secondselection sec_sel = new secondselection() { TopLevel = false, TopMost = true };
            dashbaord.instance.pnl.Controls.Add(sec_sel);
            sec_sel.Show();
            sec_sel.Dock = DockStyle.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainmenu mm = new mainmenu();
            Hide();
            mm.ShowDialog();
            Close();
        }
    }
}
