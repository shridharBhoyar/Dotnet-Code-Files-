using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox
{
    public partial class Form1 : Form
    {
        string a = "";
        string b="";
        string m = "";
        string n = "";


        public Form1()
        {
            InitializeComponent();
        }

       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                a = checkBox1.Text;
            }
            else
            {
                a = "";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked == true)
            {
                b = checkBox2.Text;
            }
            else
            {
                b = "";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox3.Checked == true)
            {
                m = checkBox3.Text;
            }
            else
            {
                m = "";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox4.Checked == true)
            {
                n = checkBox4.Text;
            }
            else
            {
                n = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you click " + a +" " + b + " " + m +" "+ n);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = checkBox5.Checked;
        }

    }
}
