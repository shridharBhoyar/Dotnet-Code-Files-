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
    public partial class singup : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public singup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "insert into singup values( @name,@surname,@gender,@age,@address,@email,@pass)";
            SqlCommand cmd = new SqlCommand(quary, con);
            cmd.Parameters.AddWithValue("@name",name_text.Text);
            cmd.Parameters.AddWithValue("@surname", surname_text.Text);
            cmd.Parameters.AddWithValue("@gender", gender_combo.SelectedItem);
            cmd.Parameters.AddWithValue("@age", Age_numeric.Value);
            cmd.Parameters.AddWithValue("@address", address_text.Text);
            cmd.Parameters.AddWithValue("@email", email_text.Text);
            cmd.Parameters.AddWithValue("@pass", pass_text.Text);

            con.Open();

           int a = cmd.ExecuteNonQuery();
            if(a>0)
            {
                MessageBox.Show("sing up sussess ");
                MessageBox.Show("user name = "+name_text.Text +" password = "+pass_text.Text);
                this.Hide();
                login lg = new login();
                lg.ShowDialog();
            }
            else
            {
                MessageBox.Show("sing up faild");
            }

            con.Close();

        }
    }
}
