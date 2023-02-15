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
    public partial class easyboard : Form
    {

        public easyboard()
        {

            InitializeComponent();
        }

        int c = 0;
        short move = 0;
        Random rand = new Random();

        private void button_Click(object sender, EventArgs e)
        {

            Button bt = sender as Button;
            bt.Enabled = false;
            bt.BackColor = Color.SkyBlue;
          
                bt.Text = "X";

                if ((eb1.Text == eb2.Text && eb2.Text == eb3.Text && eb2.Text != "") ||
                    (eb4.Text == eb5.Text && eb5.Text == eb6.Text && eb5.Text != "") ||
                    (eb7.Text == eb8.Text && eb8.Text == eb9.Text && eb8.Text != "") ||
                    (eb1.Text == eb4.Text && eb4.Text == eb7.Text && eb4.Text != "") ||
                    (eb2.Text == eb5.Text && eb5.Text == eb8.Text && eb5.Text != "") ||
                    (eb3.Text == eb6.Text && eb6.Text == eb9.Text && eb6.Text != "") ||
                    (eb1.Text == eb5.Text && eb5.Text == eb9.Text && eb5.Text != "") ||
                    (eb3.Text == eb5.Text && eb5.Text == eb7.Text && eb5.Text != ""))
                {
                    int a = 1;
                    easywin ew = new easywin();
                    ew.Show();
                }

                if (move == 8)
                {
                    easydraw ed = new easydraw();
                    ed.Show();
                }
                move++;
                ai();
            
            }
        public void ai() {
        again:

            Button[] abtn = { eb1, eb2, eb3, eb4, eb5, eb6, eb7, eb8, eb9 };


            int[] a = new int[10];

            //check for free box
            if (eb1.Text != "") { a[1] = a[1] + 1; }
            if (eb2.Text != "") { a[2] = a[2] + 1; }
            if (eb3.Text != "") { a[3] = a[3] + 1; }
            if (eb4.Text != "") { a[4] = a[4] + 1; }
            if (eb5.Text != "") { a[5] = a[5] + 1; }
            if (eb6.Text != "") { a[6] = a[6] + 1; }
            if (eb7.Text != "") { a[7] = a[7] + 1; }
            if (eb8.Text != "") { a[8] = a[8] + 1; }
            if (eb9.Text != "") { a[9] = a[9] + 1; }

            int rn = rand.Next(0, 9);

            if (a[rn + 1] == 0)
            {
                abtn[rn].BackColor = Color.Red;
                abtn[rn].Text = "O";
            }

            else { goto again; }

            if ((eb1.Text == eb2.Text && eb2.Text == eb3.Text && eb2.Text != "") ||
                (eb4.Text == eb5.Text && eb5.Text == eb6.Text && eb5.Text != "") ||
                (eb7.Text == eb8.Text && eb8.Text == eb9.Text && eb8.Text != "") ||
                (eb1.Text == eb4.Text && eb4.Text == eb7.Text && eb4.Text != "") ||
                (eb2.Text == eb5.Text && eb5.Text == eb8.Text && eb5.Text != "") ||
                (eb3.Text == eb6.Text && eb6.Text == eb9.Text && eb6.Text != "") ||
                (eb1.Text == eb5.Text && eb5.Text == eb9.Text && eb5.Text != "") ||
                (eb3.Text == eb5.Text && eb5.Text == eb7.Text && eb5.Text != ""))
            {
                easylose el = new easylose();
                el.ShowDialog();
                tableLayoutPanel1.Enabled = false;
            }

            if (move == 8)
            {
                easydraw ed = new easydraw();
                ed.Show();
            }
            move++;

        }


        private void easyboard_Load(object sender, EventArgs e)
        {

        }

        }
    }


