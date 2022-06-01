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

namespace DateTime_With_Database
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
            bingrid();
        }


       void bingrid()
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "select * from datetime";
            SqlDataAdapter sda = new SqlDataAdapter(quary, con);
            DataTable data = new DataTable(); 
           sda.Fill(data);
           dataGridView1.DataSource = data;

            

        }

       private void button1_Click(object sender, EventArgs e)
       {
           SqlConnection con = new SqlConnection(cs);
           string quary = "insert into datetime values(@id,@name,@date,@time,@datetime)";
           SqlCommand cmd = new SqlCommand(quary,con);
           cmd.Parameters.AddWithValue("@id",textBox1.Text);
           cmd.Parameters.AddWithValue("@name", textBox2.Text);
           cmd.Parameters.AddWithValue("@date",dateTimePicker1.Value.ToString("dd/MM/yyyy"));
           cmd.Parameters.AddWithValue("@time", dateTimePicker2.Value.ToString("hh:mm:ss"));
           cmd.Parameters.AddWithValue("@datetime", dateTimePicker3.Value.ToString("dd/MM/yyyy hh:mm:ss"));

           con.Open();


          int a= cmd.ExecuteNonQuery();

           if(a>0)
           {
               MessageBox.Show("inserted");
               bingrid();
           }
           else
           {
               MessageBox.Show("inserted failed");
           }

           con.Close();
       }

       private void dataGridView1_DoubleClick(object sender, EventArgs e)
       {
           textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
           textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
           dateTimePicker1.Value = DateTime.ParseExact(Convert.ToDateTime( dataGridView1.SelectedRows[0].Cells[2].Value).ToString(),"dd/MM/yyyy",System.Globalization.CultureInfo.InvariantCulture);
          // dateTimePicker2.Value =DateTime.ParseExact( dataGridView1.SelectedRows[0].Cells[3].Value.ToString(),"hh:mm:ss",System.Globalization.CultureInfo.InvariantCulture);
           dateTimePicker2.Value = Convert.ToDateTime (dataGridView1.SelectedRows[0].Cells[3].Value);
           dateTimePicker3.Value =DateTime.ParseExact( dataGridView1.SelectedRows[0].Cells[4].Value.ToString(),"dd/MM/yyyy hh:mm:ss",System.Globalization.CultureInfo.InvariantCulture);
       }
    }
}
