using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Transform_another_Form
{

    

    public partial class Form1 : Form
    {

        public static string a;      //publi data access
        public static string b;
        public static string m;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = textBox1.Text;   //asing textbox value
            b = textBox2.Text;
            m = textBox3.Text;
            Form2 f2 = new Form2(); //connet 2nd form
            f2.Show(); //call
            
        }
    }
}
