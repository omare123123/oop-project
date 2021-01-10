using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finaaal
{
    public partial class XO : Form
    {
        public int player = 0;   
        public int count = 0;      

        public int score_x = 0;
        public int score_O = 0;
        public int score_draw = 0;
        class Functons
        {
            public void Exit()
            {
                Application.Exit();
            }



            public bool check_draw(int count)
            {

                if (count == 9)
                    return true;
                else
                    return false;
            }

        }

        public XO()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        void newgame()
        {
            player = 0;
            count = 0;
            b1.Text = b2.Text = b3.Text = b4.Text = b5.Text = b6.Text = b7.Text = b8.Text = b9.Text = "";
            b1.BackColor = b2.BackColor = b3.BackColor = b4.BackColor = b5.BackColor = b6.BackColor = b7.BackColor = b8.BackColor = b9.BackColor = Color.White;

            //  Result o3 = new Result();
            Xscore.Text = "X Score: " + score_x;
            Yscore.Text = "Y Score: " + score_y;
            draw.Text = " Draw: " + score_draw;
        }


        public bool winner()
        {
            // horizntal 
            if (b1.Text == b2.Text && b2.Text == b3.Text && b1.Text != "") return true;
            if (b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "") return true;
            if (b7.Text == b8.Text && b8.Text == b9.Text && b9.Text != "") return true;

            // verticals 

            if (b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "") return true;
            if (b2.Text == b5.Text && b5.Text == b8.Text && b5.Text != "") return true;
            if (b3.Text == b6.Text && b6.Text == b9.Text && b9.Text != "") return true;

            // diagonal
            if (b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "") return true;
            if (b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != "") return true;

            return false;
        }

        private void XO_Load(object sender, EventArgs e)
        {
            //Result o1 = new Result();
            Xscore.Text = "X Score: " + score_x;
            Yscore.Text = "O Score: " + score_O;
            draw.Text = " Draw: " + score_draw;
        }

        public void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.BackColor = Color.Orange;
            if (b.Text == "")
            {

                if (player % 2 == 0)
                {
                    b.Text = "X";
                    player++;
                    count++;
                }
                else if (player % 2 != 0)
                {
                    b.Text = "O";
                    player++;
                    count++;
                }

                //   Result o2 = new Result();
                if (winner() == true)
                {
                    if (b.Text == "X")
                    {
                        MessageBox.Show("X Won!");
                        score_x++;
                        newgame();
                    }
                    else
                    {
                        MessageBox.Show("O Won!");
                        score_O++;
                        newgame();
                    }

                }
                Functons o1 = new Functons();
                if (o1.check_draw(count))
                {

                    MessageBox.Show("DRAW!");
                    score_draw++;
                    newgame();

                }
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {

        }
        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)  //btn Exit
        {
            Functons w = new Functons();
            w.Exit();

        }
      
        private void button1_Click(object sender, EventArgs e)  //btn newgame 
        {
            newgame();
        }

       

        private void button3_Click(object sender, EventArgs e) //btn reset
        {
            score_x = score_O = score_draw = 0;
            newgame();
        }

        private void XO_Load_1(object sender, EventArgs e)
        {

        }

        private void draw_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            newgame();
        }

        private void button3_Click_1(object sender, EventArgs e)  //btn reset
        {
            score_x = score_O = score_draw = 0;
            newgame();
        }

        private void button2_Click_1(object sender, EventArgs e) //btn exit
        {
            Application.Exit();
        }
    }
}
