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

namespace Listbox_Database
{
    public partial class Form1 : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fild_listbox();
        }

 
        void fild_listbox()
        {
            listBox1.Items.Clear();
            SqlConnection con = new SqlConnection(cs);
            string quary = "select name from SPORTS";
            SqlCommand cmd = new SqlCommand(quary, con);

            con.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                string name = rd.GetString(0);
                listBox1.Items.Add(name);
            }


            con.Close();
            listBox1.Sorted = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "insert into SPORTS values (@name)";
            SqlCommand cmd = new SqlCommand(quary, con);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            con.Open();
            int a=cmd.ExecuteNonQuery();
            if(a>0)
            {
                MessageBox.Show("Inserted");
                fild_listbox();
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("Inserte Faild");

            }
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "update SPORTS set name = @name where name = @name1";
            SqlCommand cmd = new SqlCommand(quary, con);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@name1", listBox1.SelectedItem);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("updated");
                fild_listbox();
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("update Faild");

            }
            con.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "delete from SPORTS where name = @name";
            SqlCommand cmd = new SqlCommand(quary, con);
            cmd.Parameters.AddWithValue("@name", listBox1.SelectedItem);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("deleted");
                fild_listbox();
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("deleted Faild");
                
            }
            con.Close();
        }
    }
}
