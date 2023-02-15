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
    public partial class hardboard : Form
    {

        short move = 0;
        int c = 0;
        String player = "X";
        String computer = "O";
        short turn = 0;


        public hardboard()
        {
            InitializeComponent();
        }


        public void button_Click(object sender, EventArgs e)
        {
            if (turn % 2 != 0) { ai(); }
            Button bt = sender as Button;
            bt.Enabled = false;
            bt.BackColor = Color.SkyBlue;

            bt.Text = player;

            if ((hb1.Text == hb2.Text && hb2.Text == hb3.Text && hb2.Text != "") ||
                (hb4.Text == hb5.Text && hb5.Text == hb6.Text && hb5.Text != "") ||
                (hb7.Text == hb8.Text && hb8.Text == hb9.Text && hb8.Text != "") ||
                (hb1.Text == hb4.Text && hb4.Text == hb7.Text && hb4.Text != "") ||
                (hb2.Text == hb5.Text && hb5.Text == hb8.Text && hb5.Text != "") ||
                (hb3.Text == hb6.Text && hb6.Text == hb9.Text && hb6.Text != "") ||
                (hb1.Text == hb5.Text && hb5.Text == hb9.Text && hb5.Text != "") ||
                (hb3.Text == hb5.Text && hb5.Text == hb7.Text && hb5.Text != ""))
            {
                hardwin w = new hardwin();
                w.ShowDialog();
                turn++;
                tableLayoutPanel1.Enabled = false;


            }

            if (move == 8)
            {
                harddraw dw = new harddraw();
                dw.ShowDialog();
                turn++;
            }
            move++;

            if (turn % 2 == 0)
            {
                ai();
            }

        }

public void ai(){
        
     Button[] abtn = { hb1, hb2, hb3, hb4, hb5, hb6, hb7, hb8, hb9 };

            //check for empty box
            int[] a = new int[10];
            if (hb1.Text != "") { a[1] = a[1] + 1; }
            if (hb2.Text != "") { a[2] = a[2] + 1; }
            if (hb3.Text != "") { a[3] = a[3] + 1; }
            if (hb4.Text != "") { a[4] = a[4] + 1; }
            if (hb5.Text != "") { a[5] = a[5] + 1; }
            if (hb6.Text != "") { a[6] = a[6] + 1; }
            if (hb7.Text != "") { a[7] = a[7] + 1; }
            if (hb8.Text != "") { a[8] = a[8] + 1; }
            if (hb9.Text != "") { a[9] = a[9] + 1; }








            //attack horzontally to win
            if (hb1.Text == computer && hb2.Text == computer && hb3.Text == "") { abtn[2].BackColor = Color.Red; abtn[2].Text = computer; goto check; }
            if (hb1.Text == computer && hb2.Text == "" && hb3.Text == computer) { abtn[1].BackColor = Color.Red; abtn[1].Text = computer; goto check; }
            if (hb1.Text == "" && hb2.Text == computer && hb3.Text == computer) { abtn[0].BackColor = Color.Red; abtn[0].Text = computer; goto check; }

            if (hb4.Text == computer && hb5.Text == computer && hb6.Text == "") { abtn[5].BackColor = Color.Red; abtn[5].Text = computer; goto check; }
            if (hb4.Text == computer && hb5.Text == "" && hb6.Text == computer) { abtn[4].BackColor = Color.Red; abtn[4].Text = computer; goto check; }
            if (hb4.Text == "" && hb5.Text == computer && hb6.Text == computer) { abtn[3].BackColor = Color.Red; abtn[3].Text = computer; goto check; }

            if (hb7.Text == computer && hb8.Text == computer && hb9.Text == "") { abtn[8].BackColor = Color.Red; abtn[8].Text = computer; goto check; }
            if (hb7.Text == computer && hb8.Text == "" && hb9.Text == computer) { abtn[7].BackColor = Color.Red; abtn[7].Text = computer; goto check; }
            if (hb7.Text == "" && hb8.Text == computer && hb9.Text == computer) { abtn[6].BackColor = Color.Red; abtn[6].Text = computer; goto check; }


            //attack vertically to win
            if (hb1.Text == computer && hb4.Text == computer && hb7.Text == "") { abtn[6].BackColor = Color.Red; abtn[6].Text = computer; goto check; }
            if (hb1.Text == computer && hb4.Text == "" && hb7.Text == computer) { abtn[3].BackColor = Color.Red; abtn[3].Text = computer; goto check; }
            if (hb1.Text == "" && hb4.Text == computer && hb7.Text == computer) { abtn[0].BackColor = Color.Red; abtn[0].Text = computer; goto check; }

            if (hb2.Text == computer && hb5.Text == computer && hb8.Text == "") { abtn[7].BackColor = Color.Red; abtn[7].Text = computer; goto check; }
            if (hb2.Text == computer && hb5.Text == "" && hb8.Text == computer) { abtn[4].BackColor = Color.Red; abtn[4].Text = computer; goto check; }
            if (hb2.Text == "" && hb5.Text == computer && hb8.Text == computer) { abtn[1].BackColor = Color.Red; abtn[1].Text = computer; goto check; }

            if (hb3.Text == computer && hb6.Text == computer && hb9.Text == "") { abtn[8].BackColor = Color.Red; abtn[8].Text = computer; goto check; }
            if (hb3.Text == computer && hb6.Text == "" && hb9.Text == computer) { abtn[5].BackColor = Color.Red; abtn[5].Text = computer; goto check; }
            if (hb3.Text == "" && hb6.Text == computer && hb9.Text == computer) { abtn[2].BackColor = Color.Red; abtn[2].Text = computer; goto check; }


            //attack diagonally to win
            if (hb1.Text == computer && hb5.Text == computer && hb9.Text == "") { abtn[8].BackColor = Color.Red; abtn[8].Text = computer; goto check; }
            if (hb1.Text == computer && hb5.Text == "" && hb9.Text == computer) { abtn[4].BackColor = Color.Red; abtn[4].Text = computer; goto check; }
            if (hb1.Text == "" && hb5.Text == computer && hb9.Text == computer) { abtn[0].BackColor = Color.Red; abtn[0].Text = computer; goto check; }

            if (hb3.Text == computer && hb5.Text == computer && hb7.Text == "") { abtn[6].BackColor = Color.Red; abtn[6].Text = computer; goto check; }
            if (hb3.Text == computer && hb5.Text == "" && hb7.Text == computer) { abtn[4].BackColor = Color.Red; abtn[4].Text = computer; goto check; }
            if (hb3.Text == "" && hb5.Text == computer && hb7.Text == computer) { abtn[2].BackColor = Color.Red; abtn[2].Text = computer; goto check; }






            //defence horizontally
            if (hb1.Text == player && hb2.Text == player && hb3.Text == "") { abtn[2].BackColor = Color.Red; abtn[2].Text = computer; goto check; }
            if (hb1.Text == player && hb2.Text == "" && hb3.Text == player) { abtn[1].BackColor = Color.Red; abtn[1].Text = computer; goto check; }
            if (hb1.Text == "" && hb2.Text == player && hb3.Text == player) { abtn[0].BackColor = Color.Red; abtn[0].Text = computer; goto check; }

            if (hb4.Text == player && hb5.Text == player && hb6.Text == "") { abtn[5].BackColor = Color.Red; abtn[5].Text = computer; goto check; }
            if (hb4.Text == player && hb5.Text == "" && hb6.Text == player) { abtn[4].BackColor = Color.Red; abtn[4].Text = computer; goto check; }
            if (hb4.Text == "" && hb5.Text == player && hb6.Text == player) { abtn[3].BackColor = Color.Red; abtn[3].Text = computer; goto check; }

            if (hb7.Text == player && hb8.Text == player && hb9.Text == "") { abtn[8].BackColor = Color.Red; abtn[8].Text = computer; goto check; }
            if (hb7.Text == player && hb8.Text == "" && hb9.Text == player) { abtn[7].BackColor = Color.Red; abtn[7].Text = computer; goto check; }
            if (hb7.Text == "" && hb8.Text == player && hb9.Text == player) { abtn[6].BackColor = Color.Red; abtn[6].Text = computer; goto check; }


            //defence vertically
            if (hb1.Text == player && hb4.Text == player && hb7.Text == "") { abtn[6].BackColor = Color.Red; abtn[6].Text = computer; goto check; }
            if (hb1.Text == player && hb4.Text == "" && hb7.Text == player) { abtn[3].BackColor = Color.Red; abtn[3].Text = computer; goto check; }
            if (hb1.Text == "" && hb4.Text == player && hb7.Text == player) { abtn[0].BackColor = Color.Red; abtn[0].Text = computer; goto check; }

            if (hb2.Text == player && hb5.Text == player && hb8.Text == "") { abtn[7].BackColor = Color.Red; abtn[7].Text = computer; goto check; }
            if (hb2.Text == player && hb5.Text == "" && hb8.Text == player) { abtn[4].BackColor = Color.Red; abtn[4].Text = computer; goto check; }
            if (hb2.Text == "" && hb5.Text == player && hb8.Text == player) { abtn[1].BackColor = Color.Red; abtn[1].Text = computer; goto check; }

            if (hb3.Text == player && hb6.Text == player && hb9.Text == "") { abtn[8].BackColor = Color.Red; abtn[8].Text = computer; goto check; }
            if (hb3.Text == player && hb6.Text == "" && hb9.Text == player) { abtn[5].BackColor = Color.Red; abtn[5].Text = computer; goto check; }
            if (hb3.Text == "" && hb6.Text == player && hb9.Text == player) { abtn[2].BackColor = Color.Red; abtn[2].Text = computer; goto check; }          



            //first try will be to occupy center
            if (a[5] == 0) { abtn[4].BackColor = Color.Red; abtn[4].Text = computer; goto check; }



            //special condition to defend
            if (move == 3)
            {
                if (hb1.Text == player && hb9.Text == player && hb5.Text == computer) { abtn[1].BackColor = Color.Red; abtn[1].Text = computer; goto check; }
                if (hb3.Text == player && hb7.Text == player && hb5.Text == computer) { abtn[1].BackColor = Color.Red; abtn[1].Text = computer; goto check; }
            }
            
            //to occupy corner box
            if (a[1] == 0) { abtn[0].BackColor = Color.Red; abtn[0].Text = computer; goto check; }
            if (a[3] == 0) { abtn[2].BackColor = Color.Red; abtn[2].Text = computer; goto check; }
            if (a[7] == 0) { abtn[6].BackColor = Color.Red; abtn[6].Text = computer; goto check; }
            if (a[9] == 0) { abtn[8].BackColor = Color.Red; abtn[8].Text = computer; goto check; }

            //random move
            if (a[2] == 0) { abtn[1].BackColor = Color.Red; abtn[1].Text = computer; goto check; }
            if (a[4] == 0) { abtn[3].BackColor = Color.Red; abtn[3].Text = computer; goto check; }
            if (a[6] == 0) { abtn[4].BackColor = Color.Red; abtn[5].Text = computer; goto check; }
            if (a[8] == 0) { abtn[7].BackColor = Color.Red; abtn[7].Text = computer; goto check; }






            check:
            if ((hb1.Text == hb2.Text && hb2.Text == hb3.Text && hb2.Text != "") ||
                (hb4.Text == hb5.Text && hb5.Text == hb6.Text && hb5.Text != "") ||
                (hb7.Text == hb8.Text && hb8.Text == hb9.Text && hb8.Text != "") ||
                (hb1.Text == hb4.Text && hb4.Text == hb7.Text && hb4.Text != "") ||
                (hb2.Text == hb5.Text && hb5.Text == hb8.Text && hb5.Text != "") ||
                (hb3.Text == hb6.Text && hb6.Text == hb9.Text && hb6.Text != "") ||
                (hb1.Text == hb5.Text && hb5.Text == hb9.Text && hb5.Text != "") ||
                (hb3.Text == hb5.Text && hb5.Text == hb7.Text && hb5.Text != ""))
            {
                hardlose l = new hardlose();
                l.ShowDialog();
                turn++;
                tableLayoutPanel1.Enabled = false;
            }

            if (move == 8)
            {
                harddraw dw = new harddraw();
                dw.ShowDialog();
                turn++;
            }
            move++;
           
}



        private void hardboard_Load(object sender, EventArgs e)
        {

        }

        

    }
}
