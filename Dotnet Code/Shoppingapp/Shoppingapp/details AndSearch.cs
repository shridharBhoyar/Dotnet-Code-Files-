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
    public partial class details_AndSearch : Form
    {
        string cs =ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public details_AndSearch()
        {
            InitializeComponent();
            bindgridviewdata();
        }
        void bindgridviewdata()
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "sp_getBothTablesData";
           SqlCommand cmd = new SqlCommand (quary, con);
           cmd.CommandType = CommandType.StoredProcedure;

           SqlDataAdapter sda = new SqlDataAdapter();
           sda.SelectCommand = cmd;
           DataTable data = new DataTable();
           sda.Fill(data);
           dataGridView1.DataSource = data;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
                string quary = "sp_getBothTablesDataByInvoice";
                SqlCommand cmd = new SqlCommand(quary, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@invoiceID", textBox1.Text);
                SqlDataAdapter sda = new SqlDataAdapter();
               //  sda.SelectCommand.Parameters.AddWithValue("@invoiceID", textBox1.Text);
                sda.SelectCommand = cmd;
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;

                dataGridView1.Columns[10].Visible = false;

                textBox2.Text = dataGridView1.Rows[0].Cells[10].Value.ToString();


            
        }

        private void details_AndSearch_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "sp_getBothTablesDataByDateTime";
            SqlCommand cmd = new SqlCommand(quary, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@firstDate", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@secondDate", dateTimePicker2.Value);
            SqlDataAdapter sda = new SqlDataAdapter();
            //  sda.SelectCommand.Parameters.AddWithValue("@invoiceID", textBox1.Text);
            sda.SelectCommand = cmd;
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

            
        }

    }
}
