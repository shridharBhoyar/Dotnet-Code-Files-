using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace DatagridSumtableid
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Form1()
        {


            InitializeComponent();
            bingri();
            sum();
            total();
        }



        void bingri()
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "select * from demo";
           // SqlCommand cmd = new SqlCommand(quary, con);    no use cmd

            SqlDataAdapter sda= new SqlDataAdapter(quary,con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "insert into demo values (@id , @name,@gender,@age)";
            SqlCommand cmd = new SqlCommand(quary,con);
            cmd.Parameters.AddWithValue("@id",textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@gender", textBox3.Text);
            cmd.Parameters.AddWithValue("@age", textBox4.Text);

            con.Open();

            int a = cmd.ExecuteNonQuery();
            if(a>0)
            {
                MessageBox.Show("inserted");
                bingri();
                sum();
                total();
            }
            else
            {
                MessageBox.Show("inserted faild");
            }


            con.Close();

        }


        

        

        private void button1_Click(object sender, EventArgs e)
        {

            sum();
         
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            total();
        }

        void sum()
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "select count(id) from demo";
            SqlCommand cmd = new SqlCommand(quary, con);

            con.Open();

            int a = Convert.ToInt32(cmd.ExecuteScalar());

            textBox5.Text = a.ToString();
            con.Close();
        }


        void total()
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "select sum(id) from demo";
            SqlCommand cmd = new SqlCommand(quary, con);

            con.Open();

            int a = Convert.ToInt32(cmd.ExecuteScalar());

            textBox6.Text = a.ToString();
            con.Close();
        }
        
    }
}
