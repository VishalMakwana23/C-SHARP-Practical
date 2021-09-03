using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            date_set();
        }
        //Question 1
        private void btnq1_Click(object sender, EventArgs e)
        {
            string txt_q1 = txtq1.Text;
            txtq1.Text = txt_q1.ToUpper();
        }
        //Question 2
        private void txtq2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
        //Question 3
        private void btnq3_Click(object sender, EventArgs e)
        {
            string txt_q3 = txtq3.Text;
            if (rdbtnaddq3.Checked == true)
            {
                listBox1.Items.Add(txt_q3);
            }
            if (rdbtndelq3.Checked == true)
            {
                listBox1.Items.Remove(txt_q3);
            }
        }
        //Question 4
        private int lcmhcf(int n)
        {
            int hcf = 1,lcm = 1;
            int n1 = int.Parse(txt1q4.Text);
            int n2 = int.Parse(txt2q4.Text);
            int bigger = (n1 < n2) ? n2 : n1;
            while (n1 != 1 || n2 != 1)
            {
                for (int i = 2; i <= bigger; i++)
                {
                    int c = 0;
                    if (n1 % i == 0)
                    {
                        n1 = n1 / i;
                        c++;
                    }
                    if (n2 % i == 0)
                    {
                        n2 = n2 / i;
                        c++;
                    }
                    if (c >= 1)
                    {
                        if (c == 1)
                        {
                            lcm = lcm * i;
                        }
                        if (c == 2)
                        {
                            lcm = lcm * i;
                            hcf = hcf * i;
                        }
                        break;
                    }
                }
            }
            if(n == 0)
            {
                return hcf;
            }
            else
            {
                return lcm;
            }
        }
        private void rdbtnhcfq4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnhcfq4.Checked == true)
            {
                lblans.Text = lcmhcf(0).ToString();
            }
        }
        private void rdbtnlcmq4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnlcmq4.Checked == true)
            {
                lblans.Text = lcmhcf(1).ToString();
            }
        }
        //Quetion 5
        private void btnaddq5_Click(object sender, EventArgs e)
        {
            if (lst1q5.SelectedItem != null)
            {
                string item = lst1q5.SelectedItem.ToString();
                lst1q5.Items.Remove(item);
                lst2q5.Items.Add(item);
            }
        }
        private void btnremoveq5_Click(object sender, EventArgs e)
        {
            if (lst2q5.SelectedItem != null)
            {
                string item = lst2q5.SelectedItem.ToString();
                lst2q5.Items.Remove(item);
                lst1q5.Items.Add(item);
            }
        }
        //Question 6
        private int counter = 100;
        private void btnq6_Click(object sender, EventArgs e)
        {
            timerq6.Tick += new EventHandler(timerq6_Tick);
            timerq6.Interval = 500;
            timerq6.Start();
        }
        private void timerq6_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
                timerq6.Stop();
            if (counter % 2 == 0)
                txtq6.Visible = true;
            else
                txtq6.Visible = false;
        }
        //Question 7
        private void lblq7_MouseHover(object sender, EventArgs e)
        {
            txtq7.Text = lblq7.Name;
        }
        private void dateq7_MouseHover(object sender, EventArgs e)
        {
            txtq7.Text = dateq7.Name;
        }
        private void btnq7_MouseHover(object sender, EventArgs e)
        {
            txtq7.Text = btnq7.Name;
        }
        //Question 8
        DateTime dt1 = new DateTime();
        DateTime dt2 = new DateTime();
        private void date_set()
        {
            dt1 = date1q8.Value;
            dt2 = date2q8.Value;
            datelist();
        }
        private void date1q8_ValueChanged(object sender, EventArgs e)
        {
            dt1 = date1q8.Value;
            datelist();
        }
        private void date2q8_ValueChanged(object sender, EventArgs e)
        {
            dt2 = date2q8.Value;
            datelist();
        }
        private void datelist()
        {
            if(dt1 < dt2)
            {
                lstq8.Items.Clear();
                lstq8.Items.Add(dt1);
                while (dt1 < dt2)
                {
                    dt1 = dt1.AddDays(1);
                    lstq8.Items.Add(dt1);
                }
            }
        }
        //Question 9
        int leastdigit = 0;
        private void cmbq9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (cmbq9.Text != null && cmbq9.Text.All(char.IsDigit) == true)
                {
                    cmbq9.Items.Add(cmbq9.Text);
                    int maxitems = cmbq9.Items.IndexOf(cmbq9.Text);
                    if (maxitems == 0)
                    {
                        leastdigit = Int32.Parse(cmbq9.Text);
                    }
                    if (leastdigit >= Int32.Parse(cmbq9.Text))
                    {
                        leastdigit = Int32.Parse(cmbq9.Text);
                        txtq9.Text = leastdigit.ToString();
                    }
                }
            }
        }
        //Question 10
        private void hScrollBar1q10_Scroll(object sender, ScrollEventArgs e)
        {
            txtq10.Text = hScrollBar1q10.Value.ToString();
        }
        //Question 11
        private void cmbq11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbq11.Text == "ON")
            {
                txtonq11.Visible = true;
                lblonq11.Visible = true;
                txtoffq11.Visible = false;
                lbloffq11.Visible = false;
            }
            if (cmbq11.Text == "OFF")
            {
                txtonq11.Visible = false;
                lblonq11.Visible = false;
                txtoffq11.Visible = true;
                lbloffq11.Visible = true;
            }
        }
        //Question 12
        private void button1_Click(object sender, EventArgs e)
        {
            keyvowels kv = new keyvowels();
            kv.Show();
        }
        //Question 13
        private void btnq13_Click(object sender, EventArgs e)
        {
            TextEditor te = new TextEditor();
            te.Show();
        }
        //Question 14
        private void btnq14_Click(object sender, EventArgs e)
        {
            calculator cal = new calculator();
            cal.Show();
        }
        //Question 15
        private void btnq15_Click(object sender, EventArgs e)
        {
            TicTacToe ttt = new TicTacToe();
            ttt.Show();
        }
        //Question 16
        private void btnq16_Click(object sender, EventArgs e)
        {
            PuzzleGame puzzle = new PuzzleGame();
            puzzle.Show();
        }
        //Question 17
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.MaxSelectionCount = 1;
            string date = monthCalendar1.SelectionStart.ToShortDateString();
            string[] ministrs = date.Split('-');
            txtdayq17.Text = ministrs[0];
            txtmonthq17.Text = ministrs[1];
            txtyearq17.Text = ministrs[2];
        }
        //Question 18
        private void btnquizq18_Click(object sender, EventArgs e)
        {
            quizplay qplay = new quizplay();
            qplay.Show();
        }
        //Question 19
        private void btnfolderq19_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" +
                "Text (*.txt)|*.txt|"+
                "All files (*.*)|*.*";
            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "Open Files";
            openFileDialog1.ShowDialog();
        }
        //Question 20
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            txtmobile.MaxLength = 10;
            txttelephone.MaxLength = 7;
            int age = 2021 - 18;
            if(txtemail.Text == "" || txtmobile.Text == "" || txttelephone.Text == "" ||dob.Value.Year <= age)
            {
                MessageBox.Show("Field must not be empty !");
            }
            else
            {
                string email = txtemail.Text;
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);
                if (!match.Success)
                {
                    MessageBox.Show("Enter Correct Email Address");
                }
                else if(txttelephone.TextLength == 7)
                {
                    MessageBox.Show("Telephone number must be 7 digits");
                }
            }
        }

        private void txttelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                (sender as TextBox).Text = (sender as TextBox).Text + e.KeyChar;
            }
        }
    }
}
