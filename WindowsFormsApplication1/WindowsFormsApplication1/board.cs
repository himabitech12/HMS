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
    public partial class board : Form
    {
        char turn = 'X';
        short move = 0;
        public board()
        {
            InitializeComponent();
        }

        protected void Form1_Load(object sender, EventArgs e)
        {
            
            }



        protected void button_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Enabled = false;
            bt.BackColor = Color.SkyBlue;
            if (turn == 'X') {
                bt.Text = "X";
                if ((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "") ||
                    (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "") ||
                    (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "") ||
                    (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") ||
                    (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") ||
                    (b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "") ||
                    (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "") ||
                    (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != "")) {          
                        player1wins p1 = new player1wins();
                        p1.Show();
                        tableLayoutPanel1.Enabled = false;
                }
                else if (move == 8)
                {
                    draw dw = new draw();
                    dw.Show();
                }

                turn = 'O';
            }
            else if (turn == 'O') {
                bt.Text = "O";
                if ((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "") ||
                    (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "") ||
                    (b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "") ||
                    (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") ||
                    (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") ||
                    (b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "") ||
                    (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "") ||
                    (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != "")) {
                        player2wins p2 = new player2wins();
                        p2.Show();
                    
                        tableLayoutPanel1.Enabled = false;
                }
                else if(move==8){
                    draw dw = new draw();
                    dw.Show();
                }
                turn = 'X';
            }
            move++;
        }
        public void restartboard()
        {
            MessageBox.Show("how ");
            move = 0;
            b1.Enabled = true; b1.Text = ""; b1.BackColor = Color.White;
            b2.Enabled = true; b2.Text = ""; b2.BackColor = Color.White;
            b3.Enabled = true; b3.Text = ""; b3.BackColor = Color.White;
            b4.Enabled = true; b4.Text = ""; b4.BackColor = Color.White;
            b5.Enabled = true; b5.Text = ""; b5.BackColor = Color.White;
            b6.Enabled = true; b6.Text = ""; b6.BackColor = Color.White;
            b7.Enabled = true; b7.Text = ""; b7.BackColor = Color.White;
            b8.Enabled = true; b8.Text = ""; b8.BackColor = Color.White;
            b9.Enabled = true; b9.Text = ""; b9.BackColor = Color.White;
            tableLayoutPanel1.Enabled = true;


            Button[] abtn = { b1, b2, b3, b4, b5, b6, b7, b8, b9 };


            int[] a = new int[10];
            String empty = "";

            //check for free box
            if (b1.Text != "") { a[1] = a[1] + 1; }
            if (b2.Text != "") { a[2] = a[2] + 1; }
            if (b3.Text != "") { a[3] = a[3] + 1; }
            if (b4.Text != "") { a[4] = a[4] + 1; }
            if (b5.Text != "") { a[5] = a[5] + 1; }
            if (b6.Text != "") { a[6] = a[6] + 1; }
            if (b7.Text != "") { a[7] = a[7] + 1; }
            if (b8.Text != "") { a[8] = a[8] + 1; }
            if (b9.Text != "") { a[9] = a[9] + 1; }
            for (int i = 1; i <= 9; i++)
            {
                if (a[i] != 0) { abtn[i - 1].Text = empty; abtn[i - 1].Enabled = true; abtn[i - 1].BackColor = Color.White; }
            }
        }
    }
}
