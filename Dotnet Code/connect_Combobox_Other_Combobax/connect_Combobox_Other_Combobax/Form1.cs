﻿using System;
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

namespace connect_Combobox_Other_Combobax
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        DataRow dr;
        


        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       void contrycombo()
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "select * from CONTRYS ";
            SqlDataAdapter data = new SqlDataAdapter(quary, con);
           
  
           DataTable dt=new DataTable();
           data.Fill(dt);
           dr = dt.NewRow();
           dr.ItemArray = new object[] { 0,"--select contry---"};
          

           comboBox1.DataSource=dt;




        }

    }
}
