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

namespace Autocomplete_Textbox_Withsql
{
    public partial class Form1 : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;



        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        void Autocomplete()
        {

         //   string[] arr = { "sleeping", "Write", "read", "travlling", "watching" };
         //   textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
         //   textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
         //   textBox1.AutoCompleteCustomSource.AddRange(arr);

            SqlConnection con = new SqlConnection(cs);
            string quary = "select * from HOBBY";
            SqlCommand cmd = new SqlCommand(quary, con);

            con.Open();

            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            SqlDataReader rd= cmd.ExecuteReader();
            while(rd.Read())
            {
                coll.Add(rd.GetString(0));
            }

               textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
               textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
               textBox1.AutoCompleteCustomSource = coll;


            con.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Autocomplete();
        }

    }
}
