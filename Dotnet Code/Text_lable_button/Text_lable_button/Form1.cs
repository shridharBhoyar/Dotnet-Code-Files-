using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_lable_button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            string b = textBox1.Text;
            if (b == "")
            {
                MessageBox.Show("please check   ");
            }
            label4.Text = b;
            label4.Visible = true;
            
            

        }
    }
}
