using System;
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
    public partial class keyvowels : Form
    {
        public keyvowels()
        {
            InitializeComponent();
        }

        private void keyvowels_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("aeiouAEIOU".IndexOf(e.KeyChar) > -1)
            {
                lblq12.Text = "Is Vowel";
            }
            else
            {
                lblq12.Text = "Is Not Vowel";
            }
        }
    }
}
