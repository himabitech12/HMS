﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class hardwin : Form
    {

        public hardwin()
        {
            InitializeComponent();
        }
        hardboard hb = new hardboard();

        private void playagainbtn_Click(object sender, EventArgs e)
        {
            Hide();
            hb.ShowDialog();
            Close();
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void win_Load(object sender, EventArgs e)
        {

        }
    }
}
