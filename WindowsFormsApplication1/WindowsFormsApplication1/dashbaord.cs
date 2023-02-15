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
    public partial class dashbaord : Form
    {
        public static dashbaord instance;
        public Panel pnl;
        public dashbaord()
        {
            InitializeComponent();
            instance = this;
            pnl = pnl_show;

            mainmenu main_show = new mainmenu() { TopLevel = false, TopMost = true };
            main_show.Dock = DockStyle.Fill;
            pnl_show.Controls.Add(main_show);
            main_show.Show();
        }
    }
}
