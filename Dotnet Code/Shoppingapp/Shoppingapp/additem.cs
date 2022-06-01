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
    public partial class additem : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public additem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs);
            string quary = "insert into itemsdb values(@name,@price,@discount)";
            SqlCommand cmd = new SqlCommand(quary, con);
            cmd.Parameters.AddWithValue("name",textBox1.Text);
            cmd.Parameters.AddWithValue("price", textBox2.Text);
            cmd.Parameters.AddWithValue("discount", textBox3.Text);

            con.Open();

            int a = cmd.ExecuteNonQuery();
            if(a>0)
            {
                MessageBox.Show("item inserted");
            }
            else
            {
                MessageBox.Show("item not inserted");
            }
            con.Close();

        }
    }
}
