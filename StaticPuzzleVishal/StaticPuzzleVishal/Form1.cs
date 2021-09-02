using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaticPuzzleVishal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int movesnumer = 0;
        int labelIndex = 0;

        private void shuffle()
        {

            List<int> labelList = new List<int>();

            Random rand = new Random();

            foreach (Button btn in this.panel1.Controls)
            {
                while (labelList.Contains(labelIndex))
                    labelIndex = rand.Next(16);

                btn.Text = (labelIndex == 0) ? "" : labelIndex + "";
                labelList.Add(labelIndex);
            }

            movesnumer = 0;
            lblmoves.Text = "Number of Moves: " + movesnumer;
        }



        private void swapLable(object sender, EventArgs e)
        {

            Button btn = (Button)sender;

            if (btn.Text == "")
            {
                return;
            }

            Button whiteBtn = null;

            foreach (Button bt in this.panel1.Controls)
            {
                if (bt.Text == "")
                {
                    whiteBtn = bt;
                    break;
                }
            }

            if (btn.TabIndex == (whiteBtn.TabIndex - 1) ||
                btn.TabIndex == (whiteBtn.TabIndex - 4)||
                btn.TabIndex == (whiteBtn.TabIndex + 1)||
                btn.TabIndex == (whiteBtn.TabIndex + 4))
            {
                btn.BackColor = Color.White;
                whiteBtn.Text = btn.Text;
                btn.Text = "";
                movesnumer++;

                lblmoves.Text = "No Of MOVES " + movesnumer;
            }

            checkOrder();

        }

        private void checkOrder()
        {

            int index = 0;

            foreach (Button btn in this.panel1.Controls)
            {

                if(btn.Text!="" && Convert.ToInt16(btn.Text) != index)
                {
                    return;
                }

                index++;
            }

            MessageBox.Show("congrats you did in" + movesnumer + "moves");
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            shuffle();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            shuffle();
        }
    }
}
