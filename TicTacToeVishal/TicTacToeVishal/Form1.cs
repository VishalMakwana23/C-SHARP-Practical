using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeVishal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Button[,] btns;
        int size;

        int move;
        Boolean endgame;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            
           
            if(textBox1.Text != "")
            {
                btnPlay.Text = "Re Match";
                // textBox1.Text = "";
                playbox.Controls.Clear();

                move = 0;
                endgame = false;

                int locx = 0;
                int locy = 0; 
                size = Int32.Parse(textBox1.Text);
                textBox1.Text = "";
                btns = new Button[size, size];

                for (int i = 0; i < size; i++)
                {
                    locy = locy + 50;
                    for (int j = 0; j < size; j++)
                    {
                        locx = locx + 50;
                        btns[i, j] = new Button();
                        btns[i, j].Width = 50;
                        btns[i, j].Height = 50;
                        btns[i, j].Location = new Point(locx,locy);
                        playbox.Controls.Add(btns[i,j]);


                        btns[i, j].Click += new System.EventHandler(checkrun);


                    }
                    locx = 0;
                }

            }
        }

        private void checkrun(object sender, EventArgs e)
        {
           
            if((sender as Button).Text == "" && endgame == false)
            {
                if(move % 2 == 0)
                {
                    (sender as Button).Text = "X";
                }
                else
                {
                    (sender as Button).Text = "O";
                }

                move++;

                int ocount = 0;
                int xcount = 0; ;


                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if(btns[i,j].Text == "O")
                        {
                            ocount++;
                        }
                        if(btns[i,j].Text == "X")
                        {
                            xcount++;
                        }
                    }

                    //after j for loop

                    if (ocount == size) 
                    {
                        MessageBox.Show("O is Win");
                        endgame = true;
                        return;
                    }
                    if (xcount == size) 
                    {
                        MessageBox.Show("X is Win");
                        endgame = true;
                        return;
                    }

                    ocount = 0;
                    xcount = 0;

                }


                //check another iteration

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if(btns[j,i].Text == "O")
                        {
                            ocount++;
                        }
                        if (btns[j, i].Text == "X")
                        {
                            xcount++;
                        }
                    }

                    if(ocount == size)
                    {
                        MessageBox.Show("O winner");
                        endgame = true;
                        return;
                    }
                    if (xcount == size)
                    {
                        MessageBox.Show("X winner");
                        endgame = true;
                        return;
                    }

                    ocount = 0;
                    xcount = 0;
                }



                //another iteration

                for (int i = 0; i < size; i++)
                {
                   
                    if(btns[i,i].Text == "O")
                    {
                        ocount++;
                    }
                    if (btns[i, i].Text == "X")
                    {
                        xcount++;
                    }
                }

                if(ocount == size)
                {
                    MessageBox.Show("O win");
                    endgame = true;
                    return;
                }

                if (xcount == size)
                {
                    MessageBox.Show("x win");
                    endgame = true;
                    return;
                }

                ocount = 0;
                xcount = 0;

                //another iteration

                int jk = size - 1;

                for (int i = 0; i < size; i++)
                {
                    if(btns[i,jk].Text == "O")
                    {
                        ocount++;
                    }
                    if (btns[i, jk].Text == "O")
                    {
                        xcount++;
                    }
                    jk--;
                }

                if (ocount == size)
                {
                    MessageBox.Show("O win");
                    endgame = true;
                    return;
                }

                if (xcount == size)
                {
                    MessageBox.Show("x win");
                    endgame = true;
                    return;
                }

                if(move == (size * size))
                {
                    MessageBox.Show("match draw");
                }
            } 
        }
    }
}
