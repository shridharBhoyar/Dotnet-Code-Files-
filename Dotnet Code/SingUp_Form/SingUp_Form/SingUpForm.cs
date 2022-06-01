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

namespace SingUp_Form
{
    public partial class SingUpForm : Form
    {
        public SingUpForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void id_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(id.Text)==true)
            {
                id.Focus();
                errorProvider1.SetError(this.id, "Fill ID");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void name_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text) == true)
            {
                name.Focus();
                errorProvider1.SetError(this.name, "Fill ID");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void fname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fname.Text) == true)
            {
                fname.Focus();
                errorProvider1.SetError(this.fname, "Fill ID");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void sname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sname.Text) == true)
            {
                sname.Focus();
                errorProvider1.SetError(this.sname, "Fill ID");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void gender_Leave(object sender, EventArgs e)
        {
            if (gender.SelectedItem ==null)
            {
                gender.Focus();
                errorProvider1.SetError(this.gender, "Fill gender");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void numericUpDown1_Leave(object sender, EventArgs e)
        {
           
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(email.Text) == true)
            {
                email.Focus();
                errorProvider1.SetError(this.email, "Fill ID");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void pass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pass.Text) == true)
            {
                pass.Focus();
                errorProvider1.SetError(this.pass, "Fill ID");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void cpass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cpass.Text) == true)
            {
                cpass.Focus();
                errorProvider1.SetError(this.cpass, "Fill ID");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);

            string quary2 = "select * from SINGUP where ID=@id";
            SqlCommand cmd2 = new SqlCommand(quary2, con);
            cmd2.Parameters.AddWithValue("@id",id.Text);
            con.Open();
            SqlDataReader rd= cmd2.ExecuteReader();

            if (rd.HasRows == true)
            {
                MessageBox.Show(id.Text + " already exist");
                con.Close();
            }
            else
            {

                con.Close();

                string quary = "insert into SINGUP values (@id,@name,@fname,@sname,@gender,@class,@email,@pass)";
                SqlCommand cmd = new SqlCommand(quary, con);
                cmd.Parameters.AddWithValue("@id", id.Text);
                cmd.Parameters.AddWithValue("@name", name.Text);
                cmd.Parameters.AddWithValue("@fname", fname.Text);
                cmd.Parameters.AddWithValue("@sname", sname.Text);
                cmd.Parameters.AddWithValue("@gender", gender.SelectedItem);
                cmd.Parameters.AddWithValue("@class", stander.Value);
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.Parameters.AddWithValue("@pass", pass.Text);

                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("register sussess");
                }
                else
                {
                    MessageBox.Show("register faild");
                }

                con.Close();
            }
        }
    }
}
