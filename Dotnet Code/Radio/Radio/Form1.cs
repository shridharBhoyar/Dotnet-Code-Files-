using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                radioButton1.BackColor = Color.Red;

            }
            else if (radioButton2.Checked == true)
            {
                radioButton2.BackColor = Color.Yellow;
            }
            else if (radioButton3.Checked == true)
            {
                radioButton3.BackColor = Color.Pink;
            }
            else if (radioButton4.Checked == true)
            {
                radioButton4.BackColor = Color.Blue;
            }
            else
            {
                MessageBox.Show("please choose");
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.Black;

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            
            groupBox1.BackColor = Color.Green;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Red;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Yellow;
        }
    }
}
