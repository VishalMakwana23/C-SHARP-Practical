using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dynamictictactoe
{
    public partial class Form1 : Form
    {
        int xwins = 0;
        int ywins = 0;
        Button[] b = new Button[9];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i= 0;i< 9; i++)
            {
                b[i] = new Button();
                b[i].Width = 100;
                b[i].Height = 100;
                b[i].Click +=new EventHandler (Form1_Click);
                flowLayoutPanel1.Controls.Add(b[i]);
            }
        }
        int flag = 0;
        int t = 0;

        void reset()
        {
            for(int i = 0; i < 9; i++)
            {
                b[i].Enabled = true;
                b[i].Text = "";
                t = 0;
            }
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if(flag == 0)
            {
                bt.Text = "X";
                flag = 1;
            }
            else
            {
                bt.Text = "O";
                flag = 0;
            }

            bt.Enabled = false;
            t++;
            check();
            if (t == 9)
            {
                MessageBox.Show("draw");
                reset();
            }
        }

        void check()
        {
            if(b[0].Text == b[1].Text && b[1].Text == b[2].Text && b[0].Text!="")
            {
                MessageBox.Show(b[0].Text + "wins");
                if(b[0].Text == "X")
                {
                    xwins++;
                    lblx.Text = xwins.ToString();
                }
                else
                {
                    ywins++;
                    lbly.Text = ywins.ToString();
                }
                reset();
            }

            if (b[3].Text == b[4].Text && b[4].Text == b[5].Text && b[3].Text != "")
            {
                MessageBox.Show(b[3].Text + "wins");
                if (b[0].Text == "X")
                {
                    xwins++;
                    lblx.Text = xwins.ToString();
                }
                else
                {
                    ywins++;
                    lbly.Text = ywins.ToString();
                }
                reset();
            }

            if (b[6].Text == b[7].Text && b[7].Text == b[8].Text && b[6].Text != "")
            {
                MessageBox.Show(b[6].Text + "wins");
                if (b[0].Text == "X")
                {
                    xwins++;
                    lblx.Text = xwins.ToString();
                }
                else
                {
                    ywins++;
                    lbly.Text = ywins.ToString();
                }
                reset();
            }

            if (b[0].Text == b[3].Text && b[0].Text == b[6].Text && b[0].Text != "")
            {
                MessageBox.Show(b[0].Text + "wins");
                if (b[0].Text == "X")
                {
                    xwins++;
                    lblx.Text = xwins.ToString();
                }
                else
                {
                    ywins++;
                    lbly.Text = ywins.ToString();
                }
                reset();
            }

            if (b[1].Text == b[4].Text && b[1].Text == b[7].Text && b[1].Text != "")
            {
                MessageBox.Show(b[1].Text + "wins");
                if (b[0].Text == "X")
                {
                    xwins++;
                    lblx.Text = xwins.ToString();
                }
                else
                {
                    ywins++;
                    lbly.Text = ywins.ToString();
                }
                reset();
            }

            if (b[2].Text == b[5].Text && b[2].Text == b[8].Text && b[2].Text != "")
            {
                MessageBox.Show(b[2].Text + "wins");
                if (b[0].Text == "X")
                {
                    xwins++;
                    lblx.Text = xwins.ToString();
                }
                else
                {
                    ywins++;
                    lbly.Text = ywins.ToString();
                }
                reset();
            }

            if (b[0].Text == b[4].Text && b[0].Text == b[8].Text && b[0].Text != "")
            {
                MessageBox.Show(b[0].Text + "wins");
                if (b[0].Text == "X")
                {
                    xwins++;
                    lblx.Text = xwins.ToString();
                }
                else
                {
                    ywins++;
                    lbly.Text = ywins.ToString();
                }
                reset();
            }

            if (b[2].Text == b[4].Text && b[4].Text == b[6].Text && b[2].Text != "")
            {
                MessageBox.Show(b[2].Text + "wins");
                if (b[0].Text == "X")
                {
                    xwins++;
                    lblx.Text = xwins.ToString();
                }
                else
                {
                    ywins++;
                    lbly.Text = ywins.ToString();
                }
                reset();
            }
        }

        
    }
}
