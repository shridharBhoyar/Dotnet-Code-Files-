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

namespace ComboBox_Database
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;


        public Form1()
        {
            InitializeComponent();
        }

        void bindcombobox()
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "select * from EMPLOYEE_D";
            SqlCommand cmd = new SqlCommand(quary, con);

            con.Open();

            SqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                string nam = rd.GetString(1);
                comboBox1.Items.Add(nam);
            }

            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindcombobox();
        }
    }
}
