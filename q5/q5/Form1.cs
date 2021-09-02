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

namespace q5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=HRK\SQLEXPRESS;Initial Catalog=tempdb;Integrated Security=True");

        //SqlCommandBuilder cmdb = new SqlCommandBuilder();

        SqlCommand cmd = new SqlCommand();

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "")
            {
                MessageBox.Show("Enter the data...");
            }
            else
            {
                try
                {
                    int x = 0;

                    con.Open();
                    
                    
                    //cmd.CommandText = "insert into stud(Name,surname,Email,course,stratdate,enddate) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + DateTime.Parse(dateTimePicker1.Text) + "','" + DateTime.Parse(dateTimePicker2.Text) + "')";
                    //cmd.Connection = con;
                    //x = cmd.ExecuteNonQuery();


                    SqlDataAdapter da = new SqlDataAdapter("insert into stud(Name,surname,Email,course,stratdate,enddate) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + DateTime.Parse(dateTimePicker1.Text) + "','" + DateTime.Parse(dateTimePicker2.Text) + "')", con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);


                    this.studTableAdapter.Fill(this.tempdbDataSet.stud);
                    con.Close();

                    if (x == 1)
                    {
                        MessageBox.Show("data is inserted");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int x = 0;

                con.Open();

                //cmd.CommandText = "update stud set Name = '" + textBox1.Text + "',surname = '" + textBox2.Text + "',Email = '" + textBox3.Text + "',course = '" + textBox4.Text + "',stratdate = '" + DateTime.Parse(dateTimePicker1.Text) + "',enddate = '" + DateTime.Parse(dateTimePicker2.Text) + "' where Id='" + textBox5.Text + "'";
                //cmd.Connection = con;
                //x = cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter("update stud set Name = '" + textBox1.Text + "',surname = '" + textBox2.Text + "',Email = '" + textBox3.Text + "',course = '" + textBox4.Text + "',stratdate = '" + DateTime.Parse(dateTimePicker1.Text) + "',enddate = '" + DateTime.Parse(dateTimePicker2.Text) + "' where Id='" + textBox5.Text + "'", con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                this.studTableAdapter.Fill(this.tempdbDataSet.stud);

                con.Close();

                if (x == 1)
                {
                    MessageBox.Show("data is updated successfull");
                    //clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           try {
                int x = 0;
                con.Open();

                //cmd.CommandText = "delete from stud where Id = '" + textBox5.Text + "' ";
                //cmd.Connection = con;
                //x = cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter("delete from stud where Id = '" + textBox5.Text + "' ", con);
                DataSet ds = new DataSet();
                da.Fill(ds);

                this.studTableAdapter.Fill(this.tempdbDataSet.stud);

                con.Close();

                if (x == 1)
                {
                    MessageBox.Show("data is deleted");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void show()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from stud",con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            //dataGridView1.DataSource = ds.Tables[0];
            //studBindingSource.DataSource = ds.Tables[0];
            //dataGridView1.DataSource = studBindingSource;
            //dataGridView1.DataBindings;
        }

        public void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tempdbDataSet.stud' table. You can move, or remove it, as needed.
            this.studTableAdapter.Fill(this.tempdbDataSet.stud);
      
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from stud", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}


/* discounnect 
DataSet ds;
SqlDataAdapter da;
SqlConnection con;
SqlCommandBuilder bldr;
*/
