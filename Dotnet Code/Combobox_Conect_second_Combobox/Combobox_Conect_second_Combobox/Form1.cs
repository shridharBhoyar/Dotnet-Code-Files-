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

namespace Combobox_Conect_second_Combobox
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        DataRow dr;

        public Form1()
        {
            InitializeComponent();
            bindcombo();
        }

        void bindcombo()
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "select * from CONTRYS";
            SqlDataAdapter sda = new SqlDataAdapter(quary, con);
            DataTable data = new DataTable();
            sda.Fill(data);

            dr = data.NewRow();
            dr.ItemArray = new object[] {0, "--select"};
            data.Rows.InsertAt(dr, 0);
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "CONTRY_ID";
            comboBox1.DataSource = data;



        }


        void bindcityidcombo(int contryid)
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "select * from CITYS where CONTRY_ID=@c_id";
            SqlDataAdapter sda = new SqlDataAdapter(quary, con);
            sda.SelectCommand.Parameters.AddWithValue("@c_id",contryid);
            DataTable data = new DataTable();
            sda.Fill(data);

            dr = data.NewRow();
            dr.ItemArray = new object[] { 0, "--select city" };
            data.Rows.InsertAt(dr, 0);
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "CITY_ID";
            comboBox2.DataSource = data;



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedValue.ToString()!=null)
            {
                int  contryid = Convert.ToInt32( comboBox1.SelectedValue.ToString());
                bindcityidcombo(contryid);
            }
        }



    }
}
