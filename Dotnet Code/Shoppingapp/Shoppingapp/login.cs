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

namespace Shoppingapp
{
    public partial class login : Form
    {
        public static string user = "";
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public login()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string quary = "select * from singup where name=@user and password=@pass";
            SqlCommand cmd = new SqlCommand(quary,con);
            cmd.Parameters.AddWithValue("@user",textBox1.Text);
            cmd.Parameters.AddWithValue("@pass",textBox2.Text);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.HasRows==true)
            {
                MessageBox.Show("login susses");
                user = textBox1.Text;
                Form1 fm = new Form1();
                this.Hide();
                fm.ShowDialog();
              
            }
            else
            {
                MessageBox.Show("login faild");
            }

            con.Close();


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            singup sg = new singup();
            this.Hide();
            sg.ShowDialog();
        }
    }
}
