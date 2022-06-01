using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace SingUpForm
{
    public partial class singupPage : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "insert into SingUp values(@fnam,@lnam,@age,@gender,@mail,@pass)";
            SqlCommand cmd = new SqlCommand(quary,con);
            cmd.Parameters.AddWithValue("@fnam",TextBox1.Text);
            cmd.Parameters.AddWithValue("@lnam", TextBox2.Text);
            cmd.Parameters.AddWithValue("@age", TextBox3.Text);
            cmd.Parameters.AddWithValue("@gender", DropDownList1.SelectedItem.Value);
            cmd.Parameters.AddWithValue("@mail", TextBox4.Text);
            cmd.Parameters.AddWithValue("@pass", TextBox5.Text);

            con.Open();
            int a=cmd.ExecuteNonQuery();
            if(a>0)
            {
                Response.Write("data added");
            }
            else
            {
                Response.Write("data not added");
            }
            con.Close();


        }


    }
}