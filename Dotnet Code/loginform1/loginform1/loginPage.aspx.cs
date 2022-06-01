using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace loginform1
{
    public partial class loginPage : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "select * from SingUp where Email=@email and Password=@pass";
            SqlCommand cmd = new SqlCommand(quary,con);
            cmd.Parameters.AddWithValue("@email",TextBox1.Text);
            cmd.Parameters.AddWithValue("@pass", TextBox2.Text);
            con.Open();

            SqlDataReader dr= cmd.ExecuteReader();

            if(dr.HasRows)
            {
                Response.Write("succes");
            }
            else
            {
                Response.Write("faild");
            }

            con.Close();
        }

        
    }
}