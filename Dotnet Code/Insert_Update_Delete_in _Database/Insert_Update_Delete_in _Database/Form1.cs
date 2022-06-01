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

namespace Insert_Update_Delete_in__Database
{
    public partial class Form1 : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);

            string quary = "select from EMPLOYEE where id=@id ";

            string query = "insert into EMPLOYEE values(@id,@name,@gender,@age,@post,@salary)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id",id.Text);
            cmd.Parameters.AddWithValue("@name", name.Text);
            cmd.Parameters.AddWithValue("@gender", gender.SelectedItem);
            cmd.Parameters.AddWithValue("@age", age.Value);
            cmd.Parameters.AddWithValue("@post", post.SelectedItem);
            cmd.Parameters.AddWithValue("@salary", salary.Text);

            con.Open();

           int a= cmd.ExecuteNonQuery();
           if(a>0)
           {
               MessageBox.Show("Inserted Success");
                BindGridView();
           }
            else
           {
               MessageBox.Show("Inserted Faild");
           }

            con.Close();
            resetcontrol();
        }

        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "select *from EMPLOYEE";
            SqlDataAdapter sda = new SqlDataAdapter(quary, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "update EMPLOYEE set id=@id,name=@name,gender=@gender,age=@age,post=@post,salary=@salary where id=@id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id.Text);
            cmd.Parameters.AddWithValue("@name", name.Text);
            cmd.Parameters.AddWithValue("@gender", gender.SelectedItem);
            cmd.Parameters.AddWithValue("@age", age.Value);
            cmd.Parameters.AddWithValue("@post", post.SelectedItem);
            cmd.Parameters.AddWithValue("@salary", salary.Text);

            con.Open();

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("updated Success");
                BindGridView();
            }
            else
            {
                MessageBox.Show("updated Faild");
            }

            con.Close();
            resetcontrol();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            gender.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            age.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value);
            post.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            salary.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "delete from EMPLOYEE where id=@id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id.Text);
            
            con.Open();

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Deleted Success");
                BindGridView();
            }
            else
            {
                MessageBox.Show("Deleted Faild");
            }

            con.Close();
            resetcontrol();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            resetcontrol();
        }

        void resetcontrol()
        {
            id.Clear();
            name.Clear();
            gender.SelectedItem=null;
            age.Value=0;
            post.SelectedItem = null;
            salary.Clear();
            id.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "select * from EMPLOYEE where name like @name + '%'";

            SqlDataAdapter sd = new SqlDataAdapter(quary,con);
            sd.SelectCommand.Parameters.AddWithValue("@name",textBox1.Text.Trim());
            
            DataTable data = new DataTable();
            sd.Fill(data);
            

            if(data.Rows.Count>0)
            {
                dataGridView1.DataSource = data;
            }
            else
            {
                MessageBox.Show("No row Found");
                dataGridView1.DataSource = null;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs);
            string quary = "select * from EMPLOYEE where name like @name + '%'";

            SqlDataAdapter sd = new SqlDataAdapter(quary, con);
            sd.SelectCommand.Parameters.AddWithValue("@name", textBox1.Text.Trim());

            DataTable data = new DataTable();
            sd.Fill(data);


            if (data.Rows.Count > 0)
            {
                dataGridView1.DataSource = data;
            }
            else
            {
                MessageBox.Show("No row Found");
                dataGridView1.DataSource = null;
            }
        }
    }
}
