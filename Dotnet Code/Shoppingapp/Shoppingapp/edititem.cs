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

namespace Shoppingapp
{
    public partial class edititem : Form
    { string cs=ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public edititem()
        {
            InitializeComponent();
            gridview();
        }


        void gridview()
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "select * from itemsdb";
            SqlDataAdapter sda = new SqlDataAdapter(quary, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "update itemsdb set item_name=@name,item_price=@price,item_discount=@discount where item_id=@id";
            SqlCommand cmd = new SqlCommand(quary, con);
            cmd.Parameters.AddWithValue("@id", textBox4.Text);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@price", textBox2.Text);
            cmd.Parameters.AddWithValue("@discount", textBox3.Text);

            con.Open();
            int a=cmd.ExecuteNonQuery();
            if(a>0)
            {
                MessageBox.Show("data updated");
                gridview();
               
            }
            else
            {
                MessageBox.Show("data not updated");
            }

            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "delete itemsdb  where item_id=@id";
            SqlCommand cmd = new SqlCommand(quary, con);
            cmd.Parameters.AddWithValue("@id", textBox4.Text);

            con.Open();
            int a=cmd.ExecuteNonQuery();
            if(a>0)
            {
                MessageBox.Show("item deleted");
                gridview();
            }
            else
            {
                MessageBox.Show("item not deleted");
            }
            con.Close();
        }
    }
}
