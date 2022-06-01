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

namespace Inserting_Data_to_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);

            string queary2 = "select * From CUSTOMER where C_ID = @cid";
            SqlCommand cmd2 = new SqlCommand(queary2, con);
            cmd2.Parameters.AddWithValue("@cid",textBox1.Text);
            con.Open();
            SqlDataReader rd =  cmd2.ExecuteReader();  // for select

            if (rd.HasRows == true)
            {
                MessageBox.Show(textBox1.Text + " id is already Exist");
            }
            else
            {

                con.Close();

                string query = "insert into CUSTOMER values (@cid,@cname,@cgender,@cadd)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@cid", textBox1.Text);
                cmd.Parameters.AddWithValue("@cname", textBox2.Text);
                cmd.Parameters.AddWithValue("@cgender", comboBox1.SelectedItem);
                cmd.Parameters.AddWithValue("@cadd", textBox3.Text);

                con.Open();
                int a = cmd.ExecuteNonQuery();  // insert update delete
                if (a > 0)
                {
                    MessageBox.Show("Customers  added");
                }
                else
                {
                    MessageBox.Show("Customers  Faild");
                }
                con.Close();

            }
        }
    }
}
