using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NightPuzzleCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Button[,] btns;
        int size;
        int blankx, blanky, blanktag;
        Boolean endgame;

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtsize.Text != "" && Int32.Parse(txtsize.Text) > 2)
            {
                size = Int32.Parse(txtsize.Text);

                int[] cn = new int[size * size];

                Random rand = new Random();
                for (int i = 0; i < (size * size); i++)
                {
                    int a = rand.Next(1, (size * size) + 1);

                    if(i == 0)
                    {
                        cn[i] = a;
                    }
                    else
                    {
                        bool flage = true;

                        while(flage)
                        {
                            int chk = 0;

                            foreach(int c in cn)
                            {
                                if(c == a)
                                {
                                    a = rand.Next(1, (size * size) + 1);
                                    chk = 1;
                                }
                            }

                            if(chk == 0)
                            {
                                flage = false;
                                cn[i] = a;
                            }
                        }
                    }
                }


                button1.Text = "RE PLAY";
                playbox.Controls.Clear();
                endgame = false;
                int colx = 0;
                int coly = 0;

                 btns = new Button[size, size];

                int k = 0;

                for (int i = 0; i < size; i++)
                {
                    coly = coly + 50;
                    for (int j = 0; j < size; j++)
                    {
                        colx = colx + 50;

                        btns[i, j] = new Button();
                        btns[i, j].Width = 50;
                        btns[i, j].Height = 50;
                        btns[i, j].Name = (k+1).ToString();
                        btns[i, j].Tag = k + 1;

                        btns[i, j].Location = new Point(colx, coly);

                        if (cn[k] == size * size)
                        {
                            btns[i, j].Text = "";
                            blankx = i;
                            blanky = j;
                            blanktag = k + 1;
                        }
                        else
                        {
                            btns[i, j].Text = cn[k].ToString(); ;
                        }

                        playbox.Controls.Add(btns[i, j]);
                        btns[i, j].Click += new System.EventHandler(checkRun);
                        k++;

                    }
                    colx = 0;
                }

                

            }
        }
        private void checkRun(object sender, EventArgs e)
        {
            if (endgame == false)
            {

                int x = 0, y = 0, tag = 0;

                int btnadd = Int32.Parse((sender as Button).Name);

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if(btns[i,j] == (sender as Button))
                        {
                            x = i;
                            y = j;
                            tag = btnadd;
                        }
                    }
                }

                if(btnadd - size == blanktag||btnadd + size == blanktag||btnadd - 1 == blanktag && blankx == x || btnadd + 1 == blanktag && blankx == x)
                {
                    btns[blankx, blanky].Text = (sender as Button).Text;
                    (sender as Button).Text = "";
                    blankx = x;
                    blanky = y;
                    blanktag = tag;

                    int cnt = 0;

                    for (int i = 0; i < size; i++)
                    {
                        for (int j = 0; j < size; j++)
                        {
                            if(btns[i,j].Text == btns[i, j].Name)
                            {
                                cnt++;
                            }
                            if(btns[size -1,size -1] == btns[i,j] && btns[i,j].Text == "")
                            {
                                cnt++;
                            }

                           
                        }
                    }

                    if (cnt == (size * size))
                    {
                        MessageBox.Show("win");
                        endgame = true;
                        return;
                    }
                }
            }

        }
        private void Form1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
