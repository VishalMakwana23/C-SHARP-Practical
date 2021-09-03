using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment1
{
    public partial class calculator : Form
    {
        char[] op = {'+','-','/','*'};
        public calculator()
        {
            InitializeComponent();
            txtconsole.Text = "0";
            btn1.Click += new System.EventHandler(btn0_Click);
            btn2.Click += new System.EventHandler(btn0_Click);
            btn3.Click += new System.EventHandler(btn0_Click);
            btn4.Click += new System.EventHandler(btn0_Click);
            btn5.Click += new System.EventHandler(btn0_Click);
            btn6.Click += new System.EventHandler(btn0_Click);
            btn7.Click += new System.EventHandler(btn0_Click);
            btn8.Click += new System.EventHandler(btn0_Click);
            btn9.Click += new System.EventHandler(btn0_Click);
            btndot.Click += new System.EventHandler(btn0_Click);
            btnminus.Click += new System.EventHandler(btnplus_Click);
            btndivide.Click += new System.EventHandler(btnplus_Click);
            btnmultiply.Click += new System.EventHandler(btnplus_Click);
            btnpercentage.Click += new System.EventHandler(btnplus_Click);
        }
        string lastchar = "";
        double memory = 0.0;
        private void btn0_Click(object sender, EventArgs e)
        {
            if(txtconsole.Text == "0")
            {
                if ((sender as Button).Text == ".")
                {
                    txtconsole.Text = txtconsole.Text + (sender as Button).Text;
                    lastchar = (sender as Button).Text;
                }
                else
                {
                    txtconsole.Text = (sender as Button).Text;
                    lastchar = (sender as Button).Text;
                }
            }
            else
            {
                if ((sender as Button).Text == ".")
                {
                    if (txtconsole.Text.LastIndexOf('.') != -1)
                    {
                        if (txtconsole.Text.LastIndexOfAny(op) > txtconsole.Text.LastIndexOf('.'))
                        {
                            txtconsole.Text = txtconsole.Text + (sender as Button).Text;
                            lastchar = (sender as Button).Text;
                        }
                    }
                    else
                    {
                        txtconsole.Text = txtconsole.Text + (sender as Button).Text;
                        lastchar = (sender as Button).Text;
                    }
                }
                else
                {
                    txtconsole.Text = txtconsole.Text + (sender as Button).Text;
                    lastchar = (sender as Button).Text;
                }
            }
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            if (txtconsole.Text != "0")
            {
                if ((sender as Button).Text != "%")
                {
                    if (lastchar != "+" && lastchar != "-" && lastchar != "*" && lastchar != "/")
                    {
                        txtconsole.Text = txtconsole.Text + (sender as Button).Text;
                        lastchar = (sender as Button).Text;
                    }
                    else
                    {
                        txtconsole.Text = txtconsole.Text.Remove(txtconsole.Text.LastIndexOf(lastchar), 1);
                        txtconsole.Text = txtconsole.Text + (sender as Button).Text;
                        lastchar = (sender as Button).Text;
                    }
                }
                else
                {
                    double lastvalue;
                    int chk = txtconsole.Text.LastIndexOfAny(op);
                    if (chk != -1)
                    {
                        lastvalue = Double.Parse(txtconsole.Text.Substring(chk + 1, (txtconsole.Text.Length - 1 - chk)));
                        txtconsole.Text = txtconsole.Text.Replace(lastvalue.ToString(),"");
                        if (txtconsole.Text[chk] == '*' || txtconsole.Text[chk] == '/')
                        {
                            lastvalue = lastvalue / 100;
                        }
                        if (txtconsole.Text[chk] == '+' || txtconsole.Text[chk] == '-')
                        {
                            lastvalue = (lastvalue * 10 - lastvalue) / 100;
                        }
                        txtconsole.Text = txtconsole.Text + lastvalue;
                    }
                }
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (txtconsole.Text != "0")
            {
                txtconsole.Text = txtconsole.Text.Remove(txtconsole.Text.LastIndexOf(lastchar), 1);
                if (txtconsole.Text == "")
                {
                    txtconsole.Text = "0";
                    lastchar = "";
                }
                else
                {
                    lastchar = txtconsole.Text.Substring(txtconsole.Text.Length - 1);
                }
            }
        }

        private void btnce_Click(object sender, EventArgs e)
        {
            txtconsole.Text = "0";
            lastchar = "";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            string str = txtconsole.Text;
            if (str[0] != '/' && str[0] != '*')
            {
                if (str.Length - 1 != str.LastIndexOfAny(op))
                {
                    ArrayList outcome = new ArrayList();
                    ArrayList operators = new ArrayList();
                    outcome.AddRange(str.Split(op));
                    int c = outcome.Count;
                    int k = 0;
                    foreach (string i in outcome)
                    {
                        k++;
                        if (k == 1 || k == c)
                        {
                            str = str.Replace(i, "");
                        }
                        else
                        {
                            str = str.Replace(i, " ");
                        }
                    }
                    operators.AddRange(str.Split(' '));
                    string result = outcome[0].ToString();
                    k = 0;
                    foreach (string i in operators)
                    {
                        MessageBox.Show(result);
                        k++;
                        switch (i)
                        {
                            case "+":
                                result = (Double.Parse(result) + Double.Parse(outcome[k].ToString())).ToString();
                                break;
                            case "-":
                                result = (Double.Parse(result) - Double.Parse(outcome[k].ToString())).ToString();
                                break;
                            case "*":
                                result = (Double.Parse(result) * Double.Parse(outcome[k].ToString())).ToString();
                                break;
                            case "/":
                                result = (Double.Parse(result) / Double.Parse(outcome[k].ToString())).ToString();
                                break;
                            default:
                                break;
                        }
                    }
                    txtconsole.Text = result;
                }
            }
        }

        private void btnmadd_Click(object sender, EventArgs e)
        {
            btnequal_Click(sender,e);
            memory = memory + Double.Parse(txtconsole.Text);
            lblmemory.Text = lblmemory.Text + txtconsole.Text;
            txtconsole.Text = "0";
        }

        private void btnmequal_Click(object sender, EventArgs e)
        {
            txtconsole.Text = memory.ToString();
            lblmemory.Text = "";
        }

        private void btnmminus_Click(object sender, EventArgs e)
        {
            btnequal_Click(sender, e);
            memory = memory - Double.Parse(txtconsole.Text);
            lblmemory.Text = lblmemory.Text + txtconsole.Text;
            txtconsole.Text = "0";
        }

        private void txtconsole_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                btndel_Click(btndel,e);
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                btnce_Click(btnce,e);
            }
            if (e.KeyChar == '+')
            {
                btnplus_Click(btnplus, e);
            }
            if (e.KeyChar == '-')
            {
                btnplus_Click(btnminus, e);
            }
            if (e.KeyChar == '*')
            {
                btnplus_Click(btnmultiply, e);
            }
            if (e.KeyChar == '/')
            {
                btnplus_Click(btndivide, e);
            }
            if (e.KeyChar == '%')
            {
                btnplus_Click(btnpercentage, e);
            }
            if (e.KeyChar == '=' || e.KeyChar == (char)Keys.Enter)
            {
                btnequal_Click(btnequal, e);
            }
            if (e.KeyChar >= (char)Keys.D0 || e.KeyChar <= (char)Keys.D9 || e.KeyChar >= (char)Keys.NumPad0 || e.KeyChar <= (char)Keys.NumPad9 || e.KeyChar == (char)Keys.Decimal)
            {
                if (e.KeyChar == '0')
                {
                    btn0_Click(btn0, e);
                }
                if (e.KeyChar == '1')
                {
                    btn0_Click(btn1, e);
                }
                if (e.KeyChar == '2')
                {
                    btn0_Click(btn2, e);
                }
                if (e.KeyChar == '3')
                {
                    btn0_Click(btn3, e);
                }
                if (e.KeyChar == '4')
                {
                    btn0_Click(btn4, e);
                }
                if (e.KeyChar == '5')
                {
                    btn0_Click(btn5, e);
                }
                if (e.KeyChar == '6')
                {
                    btn0_Click(btn6, e);
                }
                if (e.KeyChar == '7')
                {
                    btn0_Click(btn7, e);
                }
                if (e.KeyChar == '8')
                {
                    btn0_Click(btn8, e);
                }
                if (e.KeyChar == '9')
                {
                    btn0_Click(btn9, e);
                }
                if (e.KeyChar == '.')
                {
                    btn0_Click(btndot, e);
                }
            }
        }
    }
}
