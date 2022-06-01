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
    public partial class viewdata : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public viewdata()
        {
            InitializeComponent();
            bingridview();
        }
        
        void bingridview()
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "select * from itemsdb";
            SqlDataAdapter sda = new SqlDataAdapter(quary,con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            additem ad = new additem();
            ad.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edititem ei = new edititem();
            ei.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            edititem ei = new edititem();
            ei.ShowDialog();
        }
    }
}
