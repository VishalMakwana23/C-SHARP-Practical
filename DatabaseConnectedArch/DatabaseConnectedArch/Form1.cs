using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DatabaseConnectedArch
{
    public partial class Form1 : Form
    {

        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\mca\Practical\C#\DatabaseConnectedArch\DatabaseConnectedArch\Stud.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void clear()
        {
            idTxt.Clear();
            nameTxt.Clear();
            phoneTxt.Clear();
            addressTxt.Clear();
            emailTxt.Clear();
            deptTxt.Clear();
        }


        public void disp()
        {
            cn.Open();

            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM stud";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);


            dataGridView1.DataSource = dt;

            cn.Close();
            clear();
           
        }
        private void insertBtn_Click(object sender, EventArgs e)
        {
            cn.Open();

            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "INSERT INTO stud(id,name,phone,address,email,dept) VALUES("+ idTxt.Text+",'"+ nameTxt.Text+ "','" + phoneTxt.Text + "','" + addressTxt.Text + "','" + emailTxt.Text + "','" + deptTxt.Text + "')";
            cmd.ExecuteNonQuery();
            cn.Close();
            clear();
            disp();
            MessageBox.Show("Inserted Successfully");
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            cn.Open();

            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "UPDATE stud SET name='"+nameTxt.Text+"', phone='"+phoneTxt.Text+ "',address='" + addressTxt.Text + "',email='" + emailTxt.Text + "',dept='" + deptTxt.Text + "' WHERE id="+idTxt.Text+"";
            cmd.ExecuteNonQuery();
            cn.Close();
            clear();
            disp();
            MessageBox.Show("Updated Successfully");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            cn.Open();

            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "DELETE FROM stud WHERE id="+idTxt.Text+"";
            cmd.ExecuteNonQuery();
            cn.Close();
            clear();
            disp();
            MessageBox.Show("deleted Successfully");
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            cn.Open();

            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM stud WHERE id="+idTxt.Text+"";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);


            dataGridView1.DataSource = dt;

            cn.Close();
            clear();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            disp();
        }
    }
}
