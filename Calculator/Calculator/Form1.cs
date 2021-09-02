using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnOne.Click += new System.EventHandler(btnZero_Click);
            btnTwo.Click += new System.EventHandler(btnZero_Click);
            btnThree.Click += new System.EventHandler(btnZero_Click);
            btnFour.Click += new System.EventHandler(btnZero_Click);
            btnfive.Click += new System.EventHandler(btnZero_Click);
            btnSix.Click += new System.EventHandler(btnZero_Click);
            btnSeven.Click += new System.EventHandler(btnZero_Click);
            btnEight.Click += new System.EventHandler(btnZero_Click);
            btnNine.Click += new System.EventHandler(btnZero_Click);

            btnMin.Click += new System.EventHandler(btnDiv_Click);
            btnMul.Click += new System.EventHandler(btnDiv_Click);
            btnPlus.Click += new System.EventHandler(btnDiv_Click);
           



        }


        int op1;
        int op2;
        int ans;
        bool flag = false;
        string op;
        private void btnZero_Click(object sender, EventArgs e)
        {

            if(flag)
            {
                textBox1.Text = "";
                flag = false;
            }

            if(textBox1.Text =="0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + ((sender as Button).Text);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            op1 = Int32.Parse(textBox1.Text);

            flag = true;

            textBox1.Clear();


        }

        private void btnEq_Click(object sender, EventArgs e)

        {

            op2 = Int32.Parse(textBox1.Text);
           
            if (op == "-")
            {
                ans = op1 - op2;
                textBox1.Text = ans.ToString();
            }
            else if (op == "*")
            {
                ans = op1 * op2;
                textBox1.Text = ans.ToString();
            }
            else if (op == "+")
            {
                ans = op1 + op2;
                textBox1.Text = ans.ToString();
            }
           
            else
            {
                op = "/";
                ans = op1 / op2;
                textBox1.Text = ans.ToString();
            }


        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            op = "*";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            op = "-";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            op = "+";
        }
    }
}
