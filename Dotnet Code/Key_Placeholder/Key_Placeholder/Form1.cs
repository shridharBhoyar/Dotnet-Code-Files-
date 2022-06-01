using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Key_Placeholder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter Name")
            {
                textBox1.Text = "";
            }
            
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter Name";
            }
            
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
