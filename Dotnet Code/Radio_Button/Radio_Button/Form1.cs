using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                radioButton1.BackColor = Color.Red;
            }
            else if(radioButton2.Checked)
            {
                radioButton2.BackColor = Color.Pink;
            }
            else if(radioButton3.Checked)
            {
                radioButton3.BackColor = Color.Yellow;
               
            }
            else if(radioButton4.Checked)
            {
                radioButton4.BackColor = Color.Blue;
            }
            else
            {
                MessageBox.Show("please choose ");
            }
        }

        
    }
}
